'''
Various model-related utility functions.
'''

from ncl import *

class imModelBounds:
    def __init__( self ):
        self.vmin = NclVec3()
        self.vmax = NclVec3()
        self.vminpoint = float()
        self.vmaxpoint = float()
        self.center = NclVec3()
        self.radius = float()

def calcWorldMtx( boneList, bone ):
    mtx = bone.getMatrix()
    parentWorldMtx = nclCreateMat44()
    if bone.parentIndex != -1:
        parentWorldMtx, _ = calcWorldMtx( boneList, boneList[ bone.parentIndex ] )
        mtx *= parentWorldMtx
    return ( mtx, parentWorldMtx )

def calcDistance( a, b ):
    #(a-b).magnitude
    return nclLength( a - b )

def calcBounds( vertices ) -> imModelBounds:
    # calculate boundsa
    vmin = NclVec3()
    vmin[0] = 99999999
    vmin[1] = 99999999
    vmin[2] = 99999999
    
    vmax = NclVec3()
    vmax[0] = -99999999
    vmax[1] = -99999999
    vmax[2] = -99999999
    for v in vertices:
        #print(v.position)
        if v[0] < vmin[0]: vmin[0] = v[0]
        if v[1] < vmin[1]: vmin[1] = v[1]
        if v[2] < vmin[2]: vmin[2] = v[2]
        
        if v[0] > vmax[0]: vmax[0] = v[0]
        if v[1] > vmax[1]: vmax[1] = v[1]
        if v[2] > vmax[2]: vmax[2] = v[2]
    
    center = NclVec3()
    center[0] = ( vmin[0] + vmax[0] ) / 2
    center[1] = ( vmin[1] + vmax[1] ) / 2
    center[2] = ( vmin[2] + vmax[2] ) / 2  
    radius = calcDistance( center, vmax ) 
    
    # find furthest negative point
    vminpoint = vmin[0]
    if vmin[1] < vminpoint: vminpoint = vmin[1]
    if vmin[2] < vminpoint: vminpoint = vmin[2]
    
    # find furthest positive point
    vmaxpoint = vmax[0]
    if vmax[1] > vmaxpoint: vmaxpoint = vmax[1]
    if vmax[2] > vmaxpoint: vmaxpoint = vmax[2]
    
    b = imModelBounds()
    b.vmin = vmin
    b.vmax = vmax
    b.center = center
    b.radius = radius
    b.vminpoint = vminpoint
    b.vmaxpoint = vmaxpoint
    return b