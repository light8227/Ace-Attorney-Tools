import os
import sys
from pymxs import runtime as rt
import mtmaxutil
import datetime
import traceback


def _getScriptDir():
    return os.path.dirname(os.path.realpath(__file__))

_categoryStack = []
_indentLevel = 0
_logFilePath = mtmaxutil.getLogFilePath()
_hasError = False

if os.path.exists( _logFilePath ):
    os.remove( _logFilePath )

def _log( level, msg, *args, logToFileOnly=False ):
    import mtmaxconfig
    if mtmaxconfig.debugDisableLog:
        return
    
    global _indentLevel
    formattedMsg = datetime.datetime.today().strftime('%Y-%m-%d %H:%M:%S:%f') + ' [' + level + ']: ' + (_indentLevel * ' ') + str(msg)
    if not logToFileOnly:
        print( formattedMsg, *args )
    with open( _logFilePath, 'a' ) as f:
        f.write( formattedMsg + '\n' )

def clear():
    rt.clearListener()
    _categoryStack = []
    _indentLevel = 0
    _hasError = False
    
def debug( msg, *args ):
    if mtmaxutil.isDebugEnv():
        _log( 'DEBUG', msg, *args )
    else:
        _log( 'DEBUG', msg, *args, logToFileOnly=True )
        
def info( msg, *args ):
    _log( 'INFO', msg, *args )
    
def warn( msg, *args ):
    _log( 'WARNING', msg, *args )
    
def error( msg, *args ):
    _hasError = True
    _log( 'ERROR', msg, *args )
    
def exception( e ):
    error( ''.join(traceback.format_exception( None, e, e.__traceback__ ) ) )
    
def push( cat = None ):
    global _categoryStack
    global _indentLevel
    
    _categoryStack.append( cat )
    _indentLevel += 1
    
def pop():
    global _categoryStack
    global _indentLevel
    
    _categoryStack.pop()
    _indentLevel -= 1
    
def hasError():
    return _hasError