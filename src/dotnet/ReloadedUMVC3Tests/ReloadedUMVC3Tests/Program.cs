﻿using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using IReloadedHooks = Reloaded.Hooks.ReloadedII.Interfaces.IReloadedHooks;
using Reloaded.Mod.Interfaces;
using Reloaded.Mod.Interfaces.Internal;
using ReloadedUMVC3Tests.Configuration;
using ReloadedUMVC3Tests.Configuration.Implementation;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using System.IO;
using System.Timers;

namespace ReloadedUMVC3Tests
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct sShader2
    {
        public sShader2_vtbl* __vftable;
        public sShader2_mbmr m;
    }

    [StructLayout( LayoutKind.Sequential, Pack = 1 )]
    public unsafe struct sShader2_vtbl
    {

    }

    [StructLayout( LayoutKind.Sequential, Pack = 1 )]
    public unsafe struct rShader2
    {

    }

    [StructLayout( LayoutKind.Sequential, Pack = 1 )]
    public unsafe struct ShaderObject
    {
        public byte* NamePtr;
        public byte* Name2Ptr;

        public string Name => new string( (sbyte*)NamePtr );
        public string Name2 => new string( (sbyte*)Name2Ptr );
    }

    [StructLayout( LayoutKind.Sequential, Pack = 1 )]
    public unsafe struct ShaderCacheEntry
    {
        public int ShaderHash;
        public int field_4;
        public void* ShaderTable2Ptr;
    }

    [StructLayout( LayoutKind.Sequential, Pack = 1 )]
    public unsafe struct sShader2_mbmr
    {
        public long field_0;
        public long field_8;
        public long field_10;
        public long field_18;
        public long field_20;
        public long field_28;
        public rShader2* CompiledShader;
        public ShaderObject** ShaderObjects;
        public ShaderCacheEntry* ShaderCache;
        public int* ShaderObjectIndexToCacheIndex;
        public short* ShaderTable2;
        public int ShaderObjectCount;
        // etc
    }

    [StructLayout( LayoutKind.Sequential, Pack = 1 )]
    public unsafe struct nDraw__InputLayout
    {
        public void* pVtbl;
        public fixed byte pad[ 0x10 ];
        public D3DVERTEXELEMENT9* mpElements;
    }

    [StructLayout( LayoutKind.Sequential, Pack = 1 )]
    public unsafe struct nDraw__InputLayoutElement
    {
        public byte* NamePtr;
        public uint Flags;
        public uint Flags2;

        public string Name => new string( (sbyte*)NamePtr );
    }

    public enum D3DDECLTYPE : byte
    {
        D3DDECLTYPE_FLOAT1 = 0,
        D3DDECLTYPE_FLOAT2 = 1,
        D3DDECLTYPE_FLOAT3 = 2,
        D3DDECLTYPE_FLOAT4 = 3,
        D3DDECLTYPE_D3DCOLOR = 4,
        D3DDECLTYPE_UBYTE4 = 5,
        D3DDECLTYPE_SHORT2 = 6,
        D3DDECLTYPE_SHORT4 = 7,
        D3DDECLTYPE_UBYTE4N = 8,
        D3DDECLTYPE_SHORT2N = 9,
        D3DDECLTYPE_SHORT4N = 10,
        D3DDECLTYPE_USHORT2N = 11,
        D3DDECLTYPE_USHORT4N = 12,
        D3DDECLTYPE_UDEC3 = 13,
        D3DDECLTYPE_DEC3N = 14,
        D3DDECLTYPE_FLOAT16_2 = 15,
        D3DDECLTYPE_FLOAT16_4 = 16,
        D3DDECLTYPE_UNUSED = 17
    }

    public enum D3DDECLUSAGE : byte
    {
        D3DDECLUSAGE_POSITION = 0,
        D3DDECLUSAGE_BLENDWEIGHT = 1,
        D3DDECLUSAGE_BLENDINDICES = 2,
        D3DDECLUSAGE_NORMAL = 3,
        D3DDECLUSAGE_PSIZE = 4,
        D3DDECLUSAGE_TEXCOORD = 5,
        D3DDECLUSAGE_TANGENT = 6,
        D3DDECLUSAGE_BINORMAL = 7,
        D3DDECLUSAGE_TESSFACTOR = 8,
        D3DDECLUSAGE_POSITIONT = 9,
        D3DDECLUSAGE_COLOR = 10,
        D3DDECLUSAGE_FOG = 11,
        D3DDECLUSAGE_DEPTH = 12,
        D3DDECLUSAGE_SAMPLE = 13
    }

    public enum D3DDECLMETHOD : byte
    {
        D3DDECLMETHOD_DEFAULT = 0,
        D3DDECLMETHOD_PARTIALU = 1,
        D3DDECLMETHOD_PARTIALV = 2,
        D3DDECLMETHOD_CROSSUV = 3,
        D3DDECLMETHOD_UV = 4,
        D3DDECLMETHOD_LOOKUP = 5,
        D3DDECLMETHOD_LOOKUPPRESAMPLED = 6
    }

    [StructLayout( LayoutKind.Sequential, Pack = 1 )]
    public unsafe struct D3DVERTEXELEMENT9
    {
        public short Stream;
        public short Offset;
        public D3DDECLTYPE Type;
        public D3DDECLMETHOD Method;
        public D3DDECLUSAGE Usage;
        public byte UsageIndex;
    }

    /* 148 */
    [StructLayout( LayoutKind.Sequential, Pack = 1 )]
    public unsafe struct TypeInfo_mbmr
    {
        public sbyte* Name;
        public ulong qword10;
        public fixed byte gap18[ 8 ];
        public TypeInfo* Parent;
        public TypeInfo* qword28;
        public int AllocatorId;
        public int NameHash;
    };

    /* 146 */
    [StructLayout( LayoutKind.Sequential, Pack = 1 )]
    public unsafe struct TypeInfo
    {
        public TypeInfo_vtbl* __vftable;
        public TypeInfo_mbmr m;
    };

    [StructLayout( LayoutKind.Sequential, Pack = 1 )]
    public unsafe struct TypeInfo_vtbl
    {
        public void* field_0;
        public void* field_8;
        public void* field_10;
    };

    public unsafe class Functions
    {
        [Function( CallingConventions.Microsoft), UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void sShader2__SortShaderObjects_Delegate( sShader2* This );

        [Function( CallingConventions.Microsoft ), UnmanagedFunctionPointer( CallingConvention.Cdecl )]
        public unsafe delegate nDraw__InputLayout* nDraw__InputLayout__ctor_Delegate( nDraw__InputLayout* This, nDraw__InputLayoutElement* pElements, uint elementCount );

        [Function( CallingConventions.Microsoft ), UnmanagedFunctionPointer( CallingConvention.Cdecl )]
        public unsafe delegate TypeInfo* TypeInfo__ctor_Delegate( TypeInfo* @this, sbyte* name, TypeInfo* root, ulong a4, int nameHash, int a6, char a7 );

        [Function( CallingConventions.Microsoft ), UnmanagedFunctionPointer( CallingConvention.Cdecl )]
        public unsafe delegate int CRC32__Calculate_Delegate(sbyte* name, uint init);

        public IFunction<sShader2__SortShaderObjects_Delegate> sShader2__SortShaderObjects { get; }
        public IFunction<nDraw__InputLayout__ctor_Delegate> nDraw__InputLayout__ctor { get; }
        public IFunction<TypeInfo__ctor_Delegate> TypeInfo_ctor { get; }
        public IFunction<CRC32__Calculate_Delegate> CRC32__Calculate { get; }

        public Functions( IReloadedHooks hooks )
        {
            sShader2__SortShaderObjects = hooks.CreateFunction<sShader2__SortShaderObjects_Delegate>( 0x0000000140654BF0 );
            nDraw__InputLayout__ctor = hooks.CreateFunction<nDraw__InputLayout__ctor_Delegate>( 0x0000000140903520 );
            TypeInfo_ctor = hooks.CreateFunction<TypeInfo__ctor_Delegate>( 0x0000000140456210 );
            CRC32__Calculate = hooks.CreateFunction<CRC32__Calculate_Delegate>( 0x00000001404BD540 );

        }
    }

    public class ShaderElementInfo
    {
        public string Name { get; set; }
        public D3DVERTEXELEMENT9 Element { get; set; }
    }

    public class ShaderObjectInfo
    {
        public long ShaderObjectAddress { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public int Hash { get; set; }
    }

    public class ShaderInfo : ShaderObjectInfo
    {
        public List<ShaderElementInfo> Elements { get; set; }

        public ShaderInfo()
        {
            Elements = new List<ShaderElementInfo>();
        }
    }

    public class TypeInfoData
    {
        public string Name { get; set; }
        public int Hash { get; set; }
    }

    public unsafe abstract class Dumper
    {
        public bool HasChanges { get; private set; }

        public Dumper()
        {

        }

        public void EnableSaving()
        {
            HasChanges = true;
        }

        public void DisableSaving()
            => HasChanges = false;

        public void Save()
        {
            if ( !HasChanges )
                return;

            SaveCore();
            HasChanges = false;
        }

        protected abstract void SaveCore();
    }

    public unsafe class StringHashesDumper : Dumper
    {
        private IHook<Functions.CRC32__Calculate_Delegate> mCRC32Hook;
        private Dictionary<uint, string> mStringHashes;

        public StringHashesDumper( Functions functions, IReloadedHooks hooks )
        {
            mStringHashes = new Dictionary<uint, string>();
            mCRC32Hook = functions.CRC32__Calculate.Hook( CRC32Hook );
            mCRC32Hook.Activate();
        }

        private unsafe int CRC32Hook( sbyte* pName, uint init )
        {
            DisableSaving();
            var res = mCRC32Hook.OriginalFunction( pName, init );
            var name = new string( pName );
            if ( !mStringHashes.Contains(new KeyValuePair<uint, string>((uint)res, name)) )
            {
                Console.WriteLine( $"0x{res:X8} {name}" );
                mStringHashes[ (uint)res ] = new string( pName );
            }

            EnableSaving();
            return res;
        }

        protected override void SaveCore()
        {
            using var writer = File.CreateText( "hashes.csv" );
            writer.WriteLine( "hash,name" );
            foreach ( var kvp in mStringHashes )
                writer.WriteLine( $"0x{kvp.Key:X8},{kvp.Value}" );
        }
    }

    public unsafe class TypeInfoDumper : Dumper
    {
        private IHook<Functions.TypeInfo__ctor_Delegate> mTypeInfoCtorHook;
        private List<TypeInfoData> mTypes;

        public TypeInfoDumper( Functions functions, IReloadedHooks hooks )
        {
            mTypes = new List<TypeInfoData>();
            mTypeInfoCtorHook = functions.TypeInfo_ctor.Hook( TypeInfoCtorHook );
            mTypeInfoCtorHook.Activate();
        }

        private TypeInfo* TypeInfoCtorHook( TypeInfo* @this, sbyte* name, TypeInfo* root, ulong a4, int nameHash, int a6, char a7 )
        {
            DisableSaving();
            mTypeInfoCtorHook.OriginalFunction( @this, name, root, a4, nameHash, a6, a7 );
            var typeData = new TypeInfoData() { Name = new string( name ), Hash = @this->m.NameHash };
            mTypes.Add( typeData );
            Console.WriteLine( $"Added {typeData.Name} {typeData.Hash:X8}" );
            EnableSaving( );
            return @this;
        }

        protected override void SaveCore()
        {
            using var writer = File.CreateText( "types.csv" );
            writer.WriteLine( "hash,name" );
            foreach ( var type in mTypes )
                writer.WriteLine( $"0x{type.Hash:X8},{type.Name}" );
        }
    }

    public unsafe class ShaderInfoDumper : Dumper
    {
        private List<ShaderInfo> mShaders;
        private IHook<Functions.sShader2__SortShaderObjects_Delegate> mSortShaderObjectsHook;
        private IHook<Functions.nDraw__InputLayout__ctor_Delegate> mInputLayoutCtorHook;

        public ShaderInfoDumper( Functions functions, IReloadedHooks hooks )
        {
            mShaders = new List<ShaderInfo>();

            mSortShaderObjectsHook = functions.sShader2__SortShaderObjects.Hook( SortShadersHook );
            mSortShaderObjectsHook.Activate();

            mInputLayoutCtorHook = functions.nDraw__InputLayout__ctor.Hook( InputLayoutCtorHook );
            mInputLayoutCtorHook.Activate();
        }


        private nDraw__InputLayout* InputLayoutCtorHook( nDraw__InputLayout* This, nDraw__InputLayoutElement* pElements, uint elementCount )
        {
            DisableSaving();
            var result = mInputLayoutCtorHook.OriginalFunction( This, pElements, elementCount );

            var shaderObjectAddress = (long)( (byte*)pElements - 0x38 );
            var shader = mShaders.FirstOrDefault( x => x.ShaderObjectAddress == shaderObjectAddress );

            for ( int i = 0; i < elementCount; i++ )
            {
                var element = pElements[ i ];
                shader.Elements.Add( new ShaderElementInfo() { Name = pElements[ i ].Name, Element = This->mpElements[ i ] } );
            }

            EnableSaving( );
            return result;
        }

        private unsafe void SortShadersHook( sShader2* This )
        {
            DisableSaving();
            mSortShaderObjectsHook.OriginalFunction( This );
            for ( int i = 0; i < This->m.ShaderObjectCount; i++ )
            {
                var shaderObj = This->m.ShaderObjects[ i ];
                var shaderCacheEntry = This->m.ShaderCache[ i ];

                if ( shaderObj != null && shaderObj->Name != null )
                {
                    mShaders.Add( new ShaderInfo() { ShaderObjectAddress = (long)shaderObj, Index = i, Name = shaderObj->Name, Hash = shaderCacheEntry.ShaderHash } );
                    Console.WriteLine( $"{i},{shaderObj->Name},{shaderCacheEntry.ShaderHash:X8}" );
                }
                else
                {
                    mShaders.Add( new ShaderInfo() { ShaderObjectAddress = (long)shaderObj, Index = i, Name = null, Hash = 0 } );
                    Console.WriteLine( $"{i},," );
                }
            }

            EnableSaving( );
        }

        protected override void SaveCore()
        {
            var serializer = new SerializerBuilder()
                .Build();
            var yaml = serializer.Serialize( mShaders );
            //System.Console.WriteLine( yaml );
            File.WriteAllText( "shaders.yaml", yaml );
        }
    }

    public unsafe class Program : IMod
    {
        /// <summary>
        /// Your mod if from ModConfig.json, used during initialization.
        /// </summary>
        private const string MyModId = "ReloadedUMVC3Tests";

        /// <summary>
        /// Used for writing text to the console window.
        /// </summary>
        private ILogger _logger;

        /// <summary>
        /// Provides access to the mod loader API.
        /// </summary>
        private IModLoader _modLoader;

        /// <summary>
        /// Stores the contents of your mod's configuration. Automatically updated by template.
        /// </summary>
        private Config _configuration;

        /// <summary>
        /// An interface to Reloaded's the function hooks/detours library.
        /// See: https://github.com/Reloaded-Project/Reloaded.Hooks
        ///      for documentation and samples. 
        /// </summary>
        private IReloadedHooks _hooks;

        private Functions mFunctions;
        private Timer mSaveTimer;
        private List<Dumper> mDumpers;

        private IHook<Functions.sShader2__SortShaderObjects_Delegate> mSortShaderObjectsHook;
        private IHook<Functions.nDraw__InputLayout__ctor_Delegate> mInputLayoutCtorHook;
        private IHook<Functions.TypeInfo__ctor_Delegate> mTypeInfoCtorHook;


        /// <summary>
        /// Entry point for your mod.
        /// </summary>
        public void Start( IModLoaderV1 loader )
        {
            Debugger.Launch();

            _modLoader = (IModLoader)loader;
            _logger = (ILogger)_modLoader.GetLogger();
            _modLoader.GetController<IReloadedHooks>().TryGetTarget( out _hooks );

            // Your config file is in Config.json.
            // Need a different name, format or more configurations? Modify the `Configurator`.
            // If you do not want a config, remove Configuration folder and Config class.
            var configurator = new Configurator( _modLoader.GetDirectoryForModId( MyModId ) );
            _configuration = configurator.GetConfiguration<Config>( 0 );
            _configuration.ConfigurationUpdated += OnConfigurationUpdated;

            mFunctions = new Functions( _hooks );

            mDumpers = new List<Dumper>()
            {
                //new ShaderInfoDumper( mFunctions, _hooks ),
                //new TypeInfoDumper( mFunctions, _hooks ),
                new StringHashesDumper( mFunctions, _hooks ),
            };

            mSaveTimer = new Timer( TimeSpan.FromSeconds( 1 ).TotalMilliseconds );
            mSaveTimer.Elapsed += MSaveTimer_Elapsed;
            mSaveTimer.Start();
        }

        private void MSaveTimer_Elapsed( object sender, ElapsedEventArgs e )
        {
            foreach ( var dumper in mDumpers )
            {
                dumper.Save();
            }
        }


        private void OnConfigurationUpdated( IConfigurable obj )
        {
            /*
                This is executed when the configuration file gets updated by the user
                at runtime.
            */

            // Replace configuration with new.
            _configuration = (Config)obj;
            _logger.WriteLine( $"[{MyModId}] Config Updated: Applying" );

            // Apply settings from configuration.
            // ... your code here.
        }

        /* Mod loader actions. */
        public void Suspend()
        {
            /*  Some tips if you wish to support this (CanSuspend == true)
             
                A. Undo memory modifications.
                B. Deactivate hooks. (Reloaded.Hooks Supports This!)
            */
        }

        public void Resume()
        {
            /*  Some tips if you wish to support this (CanSuspend == true)
             
                A. Redo memory modifications.
                B. Re-activate hooks. (Reloaded.Hooks Supports This!)
            */
        }

        public void Unload()
        {
            /*  Some tips if you wish to support this (CanUnload == true).
             
                A. Execute Suspend(). [Suspend should be reusable in this method]
                B. Release any unmanaged resources, e.g. Native memory.
            */
        }

        /*  If CanSuspend == false, suspend and resume button are disabled in Launcher and Suspend()/Resume() will never be called.
            If CanUnload == false, unload button is disabled in Launcher and Unload() will never be called.
        */
        public bool CanUnload() => false;
        public bool CanSuspend() => false;

        /* Automatically called by the mod loader when the mod is about to be unloaded. */
        public Action Disposing => () =>
        {

        };

        /* Contains the Types you would like to share with other mods.
           If you do not want to share any types, please remove this method and the
           IExports interface.
        
           Inter Mod Communication: https://github.com/Reloaded-Project/Reloaded-II/blob/master/Docs/InterModCommunication.md
        */
        public Type[] GetTypes() => new Type[ 0 ];

        /* This is a dummy for R2R (ReadyToRun) deployment.
           For more details see: https://github.com/Reloaded-Project/Reloaded-II/blob/master/Docs/ReadyToRun.md
        */
        public static void Main() 
        {
        }
    }
}
