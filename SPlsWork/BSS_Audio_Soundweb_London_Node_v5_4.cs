using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_BSS_AUDIO_SOUNDWEB_LONDON_NODE_V5_4
{
    public class UserModuleClass_BSS_AUDIO_SOUNDWEB_LONDON_NODE_V5_4 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INITIALIZE;
        Crestron.Logos.SplusObjects.BufferInput COMRX__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput MODULESTX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput ALLOW_INIT;
        Crestron.Logos.SplusObjects.DigitalOutput INITIALIZE_BUSY;
        Crestron.Logos.SplusObjects.StringOutput COMTX__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> MODULESRX__DOLLAR__;
        StringParameter NODE__DOLLAR__;
        ushort IMARKER1 = 0;
        ushort IMARKER2 = 0;
        ushort ITEMP = 0;
        CrestronString STEMPSTRING1;
        CrestronString STEMPSTRING2;
        CrestronString [] SOBJECTIDS;
        private void FINITTIMEOUT (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 79;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_7__" , 1000 , __SPLS_TMPVAR__WAITLABEL_7___Callback ) ;
            
            }
            
        public void __SPLS_TMPVAR__WAITLABEL_7___CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 81;
            INITIALIZE_BUSY  .Value = (ushort) ( 0 ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    private void FSENDFROMDEVICE (  SplusExecutionContext __context__, CrestronString FSTEMPSEND ) 
        { 
        ushort FIA = 0;
        ushort FICOUNT = 0;
        
        CrestronString FSTEMPOBJECTID;
        FSTEMPOBJECTID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
        
        
        __context__.SourceCodeLine = 90;
        FSTEMPOBJECTID  .UpdateValue ( Functions.Mid ( FSTEMPSEND ,  (int) ( 7 ) ,  (int) ( 6 ) )  ) ; 
        __context__.SourceCodeLine = 91;
        FICOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 92;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)6; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( FIA  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (FIA  >= __FN_FORSTART_VAL__1) && (FIA  <= __FN_FOREND_VAL__1) ) : ( (FIA  <= __FN_FORSTART_VAL__1) && (FIA  >= __FN_FOREND_VAL__1) ) ; FIA  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 94;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( FSTEMPOBJECTID , (int)( FIA ) ) == 27) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (FICOUNT == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( FIA <= 3 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( FICOUNT > 0 ) )) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 96;
                FICOUNT = (ushort) ( (FICOUNT + 1) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 98;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( FIA > 3 ) ) && Functions.TestForTrue ( Functions.BoolToInt (FICOUNT == 0) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 100;
                    break ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 92;
            } 
        
        __context__.SourceCodeLine = 103;
        FSTEMPOBJECTID  .UpdateValue ( Functions.Left ( FSTEMPOBJECTID ,  (int) ( (FICOUNT + 3) ) )  ) ; 
        __context__.SourceCodeLine = 104;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FSTEMPOBJECTID == "\u0000\u0000\u0000"))  ) ) 
            { 
            __context__.SourceCodeLine = 106;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)50; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( FIA  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (FIA  >= __FN_FORSTART_VAL__2) && (FIA  <= __FN_FOREND_VAL__2) ) : ( (FIA  <= __FN_FORSTART_VAL__2) && (FIA  >= __FN_FOREND_VAL__2) ) ; FIA  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 108;
                MODULESRX__DOLLAR__ [ FIA]  .UpdateValue ( FSTEMPSEND  ) ; 
                __context__.SourceCodeLine = 106;
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 113;
            ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__3 = (ushort)50; 
            int __FN_FORSTEP_VAL__3 = (int)1; 
            for ( FIA  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (FIA  >= __FN_FORSTART_VAL__3) && (FIA  <= __FN_FOREND_VAL__3) ) : ( (FIA  <= __FN_FORSTART_VAL__3) && (FIA  >= __FN_FOREND_VAL__3) ) ; FIA  += (ushort)__FN_FORSTEP_VAL__3) 
                { 
                __context__.SourceCodeLine = 115;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( SOBJECTIDS[ FIA ] ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (SOBJECTIDS[ FIA ] == FSTEMPOBJECTID) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 117;
                    MODULESRX__DOLLAR__ [ FIA]  .UpdateValue ( FSTEMPSEND + "\u0003\u0003\u0003\u0003"  ) ; 
                    __context__.SourceCodeLine = 118;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 113;
                } 
            
            } 
        
        
        }
        
    object INITIALIZE_OnPush_0 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort A = 0;
            
            
            __context__.SourceCodeLine = 130;
            INITIALIZE_BUSY  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 131;
            Functions.SetArray ( SOBJECTIDS , "" ) ; 
            __context__.SourceCodeLine = 132;
            FINITTIMEOUT (  __context__  ) ; 
            __context__.SourceCodeLine = 133;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)50; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (A  >= __FN_FORSTART_VAL__1) && (A  <= __FN_FOREND_VAL__1) ) : ( (A  <= __FN_FORSTART_VAL__1) && (A  >= __FN_FOREND_VAL__1) ) ; A  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 135;
                MakeString ( MODULESRX__DOLLAR__ [ A] , "Send Name{0:d} Node {1}\u0003{2}", (short)A, NODE__DOLLAR__ , "\u0003\u0003\u0003\u0003" ) ; 
                __context__.SourceCodeLine = 133;
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object MODULESTX__DOLLAR___OnChange_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 142;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 144;
            try 
                { 
                __context__.SourceCodeLine = 146;
                STEMPSTRING1  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 147;
                STEMPSTRING1  .UpdateValue ( Functions.Gather ( "\u0003\u0003\u0003\u0003\u0003" , MODULESTX__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 148;
                STEMPSTRING1  .UpdateValue ( Functions.Left ( STEMPSTRING1 ,  (int) ( (Functions.Length( STEMPSTRING1 ) - 4) ) )  ) ; 
                __context__.SourceCodeLine = 149;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "Send Name" , STEMPSTRING1 ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 151;
                    ITEMP = (ushort) ( Functions.Atoi( STEMPSTRING1 ) ) ; 
                    __context__.SourceCodeLine = 152;
                    IMARKER1 = (ushort) ( (Functions.Find( "= " , STEMPSTRING1 ) + 2) ) ; 
                    __context__.SourceCodeLine = 153;
                    IMARKER2 = (ushort) ( Functions.Find( "\u0003" , STEMPSTRING1 , IMARKER1 ) ) ; 
                    __context__.SourceCodeLine = 154;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ITEMP <= 50 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ITEMP > 0 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 156;
                        SOBJECTIDS [ ITEMP ]  .UpdateValue ( Functions.Mid ( STEMPSTRING1 ,  (int) ( IMARKER1 ) ,  (int) ( (IMARKER2 - IMARKER1) ) )  ) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 161;
                    COMTX__DOLLAR__  .UpdateValue ( STEMPSTRING1  ) ; 
                    } 
                
                } 
            
            catch (Exception __splus_exception__)
                { 
                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                
                __context__.SourceCodeLine = 166;
                GenerateUserNotice ( "BSS SoundWeb London Node: Error from modules: {0}", Functions.GetExceptionMessage (  __splus_exceptionobj__ ) ) ; 
                
                }
                
                __context__.SourceCodeLine = 142;
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object COMRX__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 173;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 175;
            try 
                { 
                __context__.SourceCodeLine = 177;
                STEMPSTRING2  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 178;
                STEMPSTRING2  .UpdateValue ( Functions.Gather ( "\u0003" , COMRX__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 179;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( STEMPSTRING2 , (int)( 1 ) ) == 6))  ) ) 
                    { 
                    __context__.SourceCodeLine = 181;
                    STEMPSTRING2  .UpdateValue ( Functions.Right ( STEMPSTRING2 ,  (int) ( (Functions.Length( STEMPSTRING2 ) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 179;
                    } 
                
                __context__.SourceCodeLine = 183;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( STEMPSTRING2 , (int)( 3 ) , (int)( 2 ) ) == NODE__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 185;
                    FSENDFROMDEVICE (  __context__ , STEMPSTRING2) ; 
                    } 
                
                } 
            
            catch (Exception __splus_exception__)
                { 
                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                
                __context__.SourceCodeLine = 190;
                GenerateUserNotice ( "BSS SoundWeb London Node: Error from device: {0}", Functions.GetExceptionMessage (  __splus_exceptionobj__ ) ) ; 
                
                }
                
                __context__.SourceCodeLine = 173;
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 255;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 256;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    STEMPSTRING1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 800, this );
    STEMPSTRING2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 800, this );
    SOBJECTIDS  = new CrestronString[ 51 ];
    for( uint i = 0; i < 51; i++ )
        SOBJECTIDS [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    
    INITIALIZE = new Crestron.Logos.SplusObjects.DigitalInput( INITIALIZE__DigitalInput__, this );
    m_DigitalInputList.Add( INITIALIZE__DigitalInput__, INITIALIZE );
    
    ALLOW_INIT = new Crestron.Logos.SplusObjects.DigitalOutput( ALLOW_INIT__DigitalOutput__, this );
    m_DigitalOutputList.Add( ALLOW_INIT__DigitalOutput__, ALLOW_INIT );
    
    INITIALIZE_BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( INITIALIZE_BUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( INITIALIZE_BUSY__DigitalOutput__, INITIALIZE_BUSY );
    
    COMTX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( COMTX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( COMTX__DOLLAR____AnalogSerialOutput__, COMTX__DOLLAR__ );
    
    MODULESRX__DOLLAR__ = new InOutArray<StringOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        MODULESRX__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( MODULESRX__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( MODULESRX__DOLLAR____AnalogSerialOutput__ + i, MODULESRX__DOLLAR__[i+1] );
    }
    
    COMRX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( COMRX__DOLLAR____AnalogSerialInput__, 10000, this );
    m_StringInputList.Add( COMRX__DOLLAR____AnalogSerialInput__, COMRX__DOLLAR__ );
    
    MODULESTX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( MODULESTX__DOLLAR____AnalogSerialInput__, 10000, this );
    m_StringInputList.Add( MODULESTX__DOLLAR____AnalogSerialInput__, MODULESTX__DOLLAR__ );
    
    NODE__DOLLAR__ = new StringParameter( NODE__DOLLAR____Parameter__, this );
    m_ParameterList.Add( NODE__DOLLAR____Parameter__, NODE__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_7___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_7___CallbackFn );
    
    INITIALIZE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INITIALIZE_OnPush_0, false ) );
    MODULESTX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( MODULESTX__DOLLAR___OnChange_1, true ) );
    COMRX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( COMRX__DOLLAR___OnChange_2, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BSS_AUDIO_SOUNDWEB_LONDON_NODE_V5_4 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_7___Callback;


const uint INITIALIZE__DigitalInput__ = 0;
const uint COMRX__DOLLAR____AnalogSerialInput__ = 0;
const uint MODULESTX__DOLLAR____AnalogSerialInput__ = 1;
const uint ALLOW_INIT__DigitalOutput__ = 0;
const uint INITIALIZE_BUSY__DigitalOutput__ = 1;
const uint COMTX__DOLLAR____AnalogSerialOutput__ = 0;
const uint MODULESRX__DOLLAR____AnalogSerialOutput__ = 1;
const uint NODE__DOLLAR____Parameter__ = 10;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
