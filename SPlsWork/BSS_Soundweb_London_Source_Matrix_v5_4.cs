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

namespace UserModule_BSS_SOUNDWEB_LONDON_SOURCE_MATRIX_V5_4
{
    public class UserModuleClass_BSS_SOUNDWEB_LONDON_SOURCE_MATRIX_V5_4 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SUBSCRIBE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput UNSUBSCRIBE__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput RX__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> INPUTFOROUTPUT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> INPUTFOROUTPUT_FB__DOLLAR__;
        UShortParameter IMAXOUTPUT;
        StringParameter OBJECTID__DOLLAR__;
        ushort XOKSUBSCRIBE = 0;
        ushort I = 0;
        ushort ITEMPNUM = 0;
        ushort IMARKER1 = 0;
        CrestronString TEMPSTRING;
        CrestronString SNODE;
        CrestronString STEMPSEND;
        CrestronString SOBJECTIDPADDED;
        ushort X = 0;
        ushort XINDEX = 0;
        ushort STATEVAR = 0;
        ushort SUBSCRIBE = 0;
        private CrestronString SEND (  SplusExecutionContext __context__, CrestronString STR1 ) 
            { 
            ushort CHECKSUM = 0;
            
            CrestronString FSTEMPRETURN;
            CrestronString SENDSTRING;
            FSTEMPRETURN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            SENDSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 91;
            CHECKSUM = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 92;
            SENDSTRING  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 93;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( STR1 ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 95;
                CHECKSUM = (ushort) ( (CHECKSUM ^ Byte( STR1 , (int)( I ) )) ) ; 
                __context__.SourceCodeLine = 96;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( I ) ) == 2) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( I ) ) == 3) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( I ) ) == 6) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( I ) ) == 21) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( I ) ) == 27) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 98;
                    MakeString ( SENDSTRING , "{0}\u001B{1}", SENDSTRING , Functions.Chr (  (int) ( (Byte( STR1 , (int)( I ) ) + 128) ) ) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 102;
                    MakeString ( SENDSTRING , "{0}{1}", SENDSTRING , Functions.Chr (  (int) ( Byte( STR1 , (int)( I ) ) ) ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 93;
                } 
            
            __context__.SourceCodeLine = 105;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 2) ) || Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 3) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 6) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 21) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 27) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 107;
                MakeString ( FSTEMPRETURN , "\u0002{0}\u001B{1}\u0003", SENDSTRING , Functions.Chr (  (int) ( (CHECKSUM + 128) ) ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 111;
                MakeString ( FSTEMPRETURN , "\u0002{0}{1}\u0003", SENDSTRING , Functions.Chr (  (int) ( CHECKSUM ) ) ) ; 
                } 
            
            __context__.SourceCodeLine = 113;
            return ( FSTEMPRETURN ) ; 
            
            }
            
        private CrestronString FPAD (  SplusExecutionContext __context__, CrestronString FSPAD ) 
            { 
            ushort FIA = 0;
            
            CrestronString FSRETURN;
            FSRETURN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            
            __context__.SourceCodeLine = 121;
            FSRETURN  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 122;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( FSPAD ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( FIA  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (FIA  >= __FN_FORSTART_VAL__1) && (FIA  <= __FN_FOREND_VAL__1) ) : ( (FIA  <= __FN_FORSTART_VAL__1) && (FIA  >= __FN_FOREND_VAL__1) ) ; FIA  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 124;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( FSPAD , (int)( FIA ) ) == 2) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( FSPAD , (int)( FIA ) ) == 3) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( FSPAD , (int)( FIA ) ) == 6) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( FSPAD , (int)( FIA ) ) == 21) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( FSPAD , (int)( FIA ) ) == 27) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 126;
                    MakeString ( FSRETURN , "{0}\u001B{1}", FSRETURN , Functions.Chr (  (int) ( (Byte( FSPAD , (int)( FIA ) ) + 128) ) ) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 130;
                    MakeString ( FSRETURN , "{0}{1}", FSRETURN , Functions.Chr (  (int) ( Byte( FSPAD , (int)( FIA ) ) ) ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 122;
                } 
            
            __context__.SourceCodeLine = 133;
            return ( FSRETURN ) ; 
            
            }
            
        private CrestronString FUNPAD (  SplusExecutionContext __context__, CrestronString STR2 ) 
            { 
            ushort J = 0;
            
            CrestronString RECEIVESTRING;
            RECEIVESTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 141;
            RECEIVESTRING  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 142;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( STR2 ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( J  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (J  >= __FN_FORSTART_VAL__1) && (J  <= __FN_FOREND_VAL__1) ) : ( (J  <= __FN_FORSTART_VAL__1) && (J  >= __FN_FOREND_VAL__1) ) ; J  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 144;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( STR2 , (int)( J ) ) == 27))  ) ) 
                    { 
                    __context__.SourceCodeLine = 146;
                    RECEIVESTRING  .UpdateValue ( RECEIVESTRING + Functions.Chr (  (int) ( (Byte( STR2 , (int)( (J + 1) ) ) - 128) ) )  ) ; 
                    __context__.SourceCodeLine = 147;
                    J = (ushort) ( (J + 1) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 151;
                    RECEIVESTRING  .UpdateValue ( RECEIVESTRING + Functions.Chr (  (int) ( Byte( STR2 , (int)( J ) ) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 142;
                } 
            
            __context__.SourceCodeLine = 154;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( RECEIVESTRING , (int)( 1 ) ) == 6))  ) ) 
                { 
                __context__.SourceCodeLine = 156;
                RECEIVESTRING  .UpdateValue ( Functions.Right ( RECEIVESTRING ,  (int) ( (Functions.Length( RECEIVESTRING ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 154;
                } 
            
            __context__.SourceCodeLine = 158;
            return ( RECEIVESTRING ) ; 
            
            }
            
        object INPUTFOROUTPUT__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 166;
                XINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 167;
                STATEVAR = (ushort) ( (XINDEX - 1) ) ; 
                __context__.SourceCodeLine = 168;
                MakeString ( STEMPSEND , "\u0088{0}\u0003{1}\u0000{2}\u0000\u0000\u0000{3}", SNODE , OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( STATEVAR ) ) , Functions.Chr (  (int) ( INPUTFOROUTPUT__DOLLAR__[ (STATEVAR + 1) ] .UshortValue ) ) ) ; 
                __context__.SourceCodeLine = 169;
                TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
                __context__.SourceCodeLine = 171;
                if ( Functions.TestForTrue  ( ( SUBSCRIBE)  ) ) 
                    { 
                    __context__.SourceCodeLine = 173;
                    MakeString ( STEMPSEND , "\u0089{0}\u0003{1}\u0000{2}\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( (XINDEX - 1) ) ) ) ; 
                    __context__.SourceCodeLine = 174;
                    TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
                    __context__.SourceCodeLine = 175;
                    Functions.ProcessLogic ( ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SUBSCRIBE__DOLLAR___OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 181;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_6__" , 20 , __SPLS_TMPVAR__WAITLABEL_6___Callback ) ;
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public void __SPLS_TMPVAR__WAITLABEL_6___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 183;
            if ( Functions.TestForTrue  ( ( XOKSUBSCRIBE)  ) ) 
                { 
                __context__.SourceCodeLine = 185;
                XOKSUBSCRIBE = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 186;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)IMAXOUTPUT  .Value; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 188;
                    MakeString ( STEMPSEND , "\u0089{0}\u0003{1}\u0000{2}\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( (I - 1) ) ) ) ; 
                    __context__.SourceCodeLine = 189;
                    TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
                    __context__.SourceCodeLine = 190;
                    Functions.ProcessLogic ( ) ; 
                    __context__.SourceCodeLine = 186;
                    } 
                
                __context__.SourceCodeLine = 192;
                SUBSCRIBE = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 193;
                XOKSUBSCRIBE = (ushort) ( 1 ) ; 
                } 
            
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object UNSUBSCRIBE__DOLLAR___OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 200;
        if ( Functions.TestForTrue  ( ( XOKSUBSCRIBE)  ) ) 
            { 
            __context__.SourceCodeLine = 202;
            XOKSUBSCRIBE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 203;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)IMAXOUTPUT  .Value; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 205;
                MakeString ( STEMPSEND , "\u008A{0}\u0003{1}\u0000{2}\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( (I - 1) ) ) ) ; 
                __context__.SourceCodeLine = 206;
                TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
                __context__.SourceCodeLine = 207;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 203;
                } 
            
            __context__.SourceCodeLine = 209;
            SUBSCRIBE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 210;
            XOKSUBSCRIBE = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

private void PROCESSRXMESSAGE (  SplusExecutionContext __context__, CrestronString PARAMDATA ) 
    { 
    
    __context__.SourceCodeLine = 216;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "Send Name" , PARAMDATA ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 218;
        ITEMPNUM = (ushort) ( Functions.Atoi( PARAMDATA ) ) ; 
        __context__.SourceCodeLine = 219;
        IMARKER1 = (ushort) ( (Functions.Find( "Node " , PARAMDATA ) + 5) ) ; 
        __context__.SourceCodeLine = 220;
        SNODE  .UpdateValue ( Functions.Mid ( PARAMDATA ,  (int) ( IMARKER1 ) ,  (int) ( 2 ) )  ) ; 
        __context__.SourceCodeLine = 221;
        SOBJECTIDPADDED  .UpdateValue ( FPAD (  __context__ , OBJECTID__DOLLAR__ )  ) ; 
        __context__.SourceCodeLine = 222;
        MakeString ( TX__DOLLAR__ , "Send Name{0:d} = {1}\u0003\u0003\u0003\u0003\u0003", (short)ITEMPNUM, SOBJECTIDPADDED ) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 224;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( PARAMDATA , (int)( 7 ) , (int)( 3 ) ) == "\u0000\u0000\u0000") ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( PARAMDATA , (int)( 7 ) , (int)( Functions.Length( SOBJECTIDPADDED ) ) ) == SOBJECTIDPADDED) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 226;
            PARAMDATA  .UpdateValue ( FUNPAD (  __context__ , PARAMDATA)  ) ; 
            __context__.SourceCodeLine = 227;
            INPUTFOROUTPUT_FB__DOLLAR__ [ (Byte( PARAMDATA , (int)( 10 ) ) + 1)]  .Value = (ushort) ( Byte( PARAMDATA , (int)( 14 ) ) ) ; 
            } 
        
        }
    
    
    }
    
object RX__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 234;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 236;
            try 
                { 
                __context__.SourceCodeLine = 238;
                TEMPSTRING  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 239;
                TEMPSTRING  .UpdateValue ( Functions.Gather ( "\u0003\u0003\u0003\u0003\u0003" , RX__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 240;
                TEMPSTRING  .UpdateValue ( Functions.Left ( TEMPSTRING ,  (int) ( (Functions.Length( TEMPSTRING ) - 4) ) )  ) ; 
                __context__.SourceCodeLine = 241;
                PROCESSRXMESSAGE (  __context__ , TEMPSTRING) ; 
                } 
            
            catch (Exception __splus_exception__)
                { 
                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                
                __context__.SourceCodeLine = 245;
                GenerateUserNotice ( "BSS SoundWeb London Source Matrix Error: {0}", Functions.GetExceptionMessage (  __splus_exceptionobj__ ) ) ; 
                
                }
                
                __context__.SourceCodeLine = 234;
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
        
        __context__.SourceCodeLine = 274;
        SUBSCRIBE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 275;
        XOKSUBSCRIBE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 276;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    TEMPSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    SNODE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    STEMPSEND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SOBJECTIDPADDED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    SUBSCRIBE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( SUBSCRIBE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( SUBSCRIBE__DOLLAR____DigitalInput__, SUBSCRIBE__DOLLAR__ );
    
    UNSUBSCRIBE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( UNSUBSCRIBE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( UNSUBSCRIBE__DOLLAR____DigitalInput__, UNSUBSCRIBE__DOLLAR__ );
    
    INPUTFOROUTPUT__DOLLAR__ = new InOutArray<AnalogInput>( 96, this );
    for( uint i = 0; i < 96; i++ )
    {
        INPUTFOROUTPUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( INPUTFOROUTPUT__DOLLAR____AnalogSerialInput__ + i, INPUTFOROUTPUT__DOLLAR____AnalogSerialInput__, this );
        m_AnalogInputList.Add( INPUTFOROUTPUT__DOLLAR____AnalogSerialInput__ + i, INPUTFOROUTPUT__DOLLAR__[i+1] );
    }
    
    INPUTFOROUTPUT_FB__DOLLAR__ = new InOutArray<AnalogOutput>( 96, this );
    for( uint i = 0; i < 96; i++ )
    {
        INPUTFOROUTPUT_FB__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( INPUTFOROUTPUT_FB__DOLLAR____AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( INPUTFOROUTPUT_FB__DOLLAR____AnalogSerialOutput__ + i, INPUTFOROUTPUT_FB__DOLLAR__[i+1] );
    }
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( RX__DOLLAR____AnalogSerialInput__, 4000, this );
    m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
    
    IMAXOUTPUT = new UShortParameter( IMAXOUTPUT__Parameter__, this );
    m_ParameterList.Add( IMAXOUTPUT__Parameter__, IMAXOUTPUT );
    
    OBJECTID__DOLLAR__ = new StringParameter( OBJECTID__DOLLAR____Parameter__, this );
    m_ParameterList.Add( OBJECTID__DOLLAR____Parameter__, OBJECTID__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_6___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_6___CallbackFn );
    
    for( uint i = 0; i < 96; i++ )
        INPUTFOROUTPUT__DOLLAR__[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( INPUTFOROUTPUT__DOLLAR___OnChange_0, false ) );
        
    SUBSCRIBE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUBSCRIBE__DOLLAR___OnPush_1, false ) );
    UNSUBSCRIBE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( UNSUBSCRIBE__DOLLAR___OnPush_2, false ) );
    RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_3, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BSS_SOUNDWEB_LONDON_SOURCE_MATRIX_V5_4 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_6___Callback;


const uint SUBSCRIBE__DOLLAR____DigitalInput__ = 0;
const uint UNSUBSCRIBE__DOLLAR____DigitalInput__ = 1;
const uint RX__DOLLAR____AnalogSerialInput__ = 0;
const uint INPUTFOROUTPUT__DOLLAR____AnalogSerialInput__ = 1;
const uint TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint INPUTFOROUTPUT_FB__DOLLAR____AnalogSerialOutput__ = 1;
const uint IMAXOUTPUT__Parameter__ = 10;
const uint OBJECTID__DOLLAR____Parameter__ = 11;

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
