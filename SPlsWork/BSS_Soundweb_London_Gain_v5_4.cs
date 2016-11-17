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

namespace UserModule_BSS_SOUNDWEB_LONDON_GAIN_V5_4
{
    public class UserModuleClass_BSS_SOUNDWEB_LONDON_GAIN_V5_4 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SUBSCRIBE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput UNSUBSCRIBE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput MUTE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput UNMUTE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput POLARITYON__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput POLARITYOFF__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogInput GAIN__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput POLARITY_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput GAIN_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        StringParameter OBJECTID__DOLLAR__;
        ushort SUBSCRIBE = 0;
        ushort VOLUME = 0;
        ushort ITEMPNUM = 0;
        ushort IMARKER1 = 0;
        CrestronString RETURNSTRING;
        CrestronString SNODE;
        CrestronString STEMPSEND;
        ushort RETURNI = 0;
        ushort XOKSUBSCRIBE = 0;
        ushort VOLUMEINPUT = 0;
        ushort XOKGAIN = 0;
        CrestronString TEMPSTRING;
        CrestronString SOBJECTIDPADDED;
        private CrestronString SEND (  SplusExecutionContext __context__, CrestronString STR1 ) 
            { 
            ushort CHECKSUM = 0;
            ushort FIB = 0;
            
            CrestronString FSTEMPRETURN;
            CrestronString SENDSTRING;
            FSTEMPRETURN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            SENDSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 83;
            CHECKSUM = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 84;
            SENDSTRING  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 85;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( STR1 ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( FIB  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (FIB  >= __FN_FORSTART_VAL__1) && (FIB  <= __FN_FOREND_VAL__1) ) : ( (FIB  <= __FN_FORSTART_VAL__1) && (FIB  >= __FN_FOREND_VAL__1) ) ; FIB  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 87;
                CHECKSUM = (ushort) ( (CHECKSUM ^ Byte( STR1 , (int)( FIB ) )) ) ; 
                __context__.SourceCodeLine = 88;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( FIB ) ) == 2) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( FIB ) ) == 3) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( FIB ) ) == 6) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( FIB ) ) == 21) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( FIB ) ) == 27) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 90;
                    MakeString ( SENDSTRING , "{0}\u001B{1}", SENDSTRING , Functions.Chr (  (int) ( (Byte( STR1 , (int)( FIB ) ) + 128) ) ) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 94;
                    MakeString ( SENDSTRING , "{0}{1}", SENDSTRING , Functions.Chr (  (int) ( Byte( STR1 , (int)( FIB ) ) ) ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 85;
                } 
            
            __context__.SourceCodeLine = 97;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 2) ) || Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 3) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 6) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 21) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 27) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 99;
                MakeString ( FSTEMPRETURN , "\u0002{0}\u001B{1}\u0003", SENDSTRING , Functions.Chr (  (int) ( (CHECKSUM + 128) ) ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 103;
                MakeString ( FSTEMPRETURN , "\u0002{0}{1}\u0003", SENDSTRING , Functions.Chr (  (int) ( CHECKSUM ) ) ) ; 
                } 
            
            __context__.SourceCodeLine = 105;
            return ( FSTEMPRETURN ) ; 
            
            }
            
        private CrestronString ITOVOLUMEPERCENT (  SplusExecutionContext __context__, ushort INT ) 
            { 
            
            __context__.SourceCodeLine = 111;
            VOLUME = (ushort) ( ((INT * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 112;
            RETURNSTRING  .UpdateValue ( "\u0000" + Functions.Chr (  (int) ( VOLUME ) ) + "\u0000\u0000"  ) ; 
            __context__.SourceCodeLine = 113;
            return ( RETURNSTRING ) ; 
            
            }
            
        private ushort VOLUMEPERCENTTOI (  SplusExecutionContext __context__, CrestronString STR ) 
            { 
            ushort FRACTION = 0;
            
            
            __context__.SourceCodeLine = 119;
            FRACTION = (ushort) ( ((Byte( STR , (int)( 3 ) ) * 256) + Byte( STR , (int)( 4 ) )) ) ; 
            __context__.SourceCodeLine = 120;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FRACTION > 32767 ))  ) ) 
                { 
                __context__.SourceCodeLine = 121;
                VOLUME = (ushort) ( (((Byte( STR , (int)( 2 ) ) + 1) * 65535) / 100) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 124;
                VOLUME = (ushort) ( ((Byte( STR , (int)( 2 ) ) * 65535) / 100) ) ; 
                } 
            
            __context__.SourceCodeLine = 126;
            RETURNI = (ushort) ( VOLUME ) ; 
            __context__.SourceCodeLine = 128;
            return (ushort)( RETURNI) ; 
            
            }
            
        private CrestronString FPAD (  SplusExecutionContext __context__, CrestronString FSPAD ) 
            { 
            ushort FIA = 0;
            
            CrestronString FSRETURN;
            FSRETURN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            
            __context__.SourceCodeLine = 137;
            FSRETURN  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 138;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( FSPAD ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( FIA  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (FIA  >= __FN_FORSTART_VAL__1) && (FIA  <= __FN_FOREND_VAL__1) ) : ( (FIA  <= __FN_FORSTART_VAL__1) && (FIA  >= __FN_FOREND_VAL__1) ) ; FIA  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 140;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( FSPAD , (int)( FIA ) ) == 2) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( FSPAD , (int)( FIA ) ) == 3) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( FSPAD , (int)( FIA ) ) == 6) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( FSPAD , (int)( FIA ) ) == 21) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( FSPAD , (int)( FIA ) ) == 27) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 142;
                    MakeString ( FSRETURN , "{0}\u001B{1}", FSRETURN , Functions.Chr (  (int) ( (Byte( FSPAD , (int)( FIA ) ) + 128) ) ) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 146;
                    MakeString ( FSRETURN , "{0}{1}", FSRETURN , Functions.Chr (  (int) ( Byte( FSPAD , (int)( FIA ) ) ) ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 138;
                } 
            
            __context__.SourceCodeLine = 149;
            return ( FSRETURN ) ; 
            
            }
            
        private CrestronString FUNPAD (  SplusExecutionContext __context__, CrestronString STR2 ) 
            { 
            ushort J = 0;
            
            CrestronString RECEIVESTRING;
            RECEIVESTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 157;
            RECEIVESTRING  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 158;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( STR2 ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( J  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (J  >= __FN_FORSTART_VAL__1) && (J  <= __FN_FOREND_VAL__1) ) : ( (J  <= __FN_FORSTART_VAL__1) && (J  >= __FN_FOREND_VAL__1) ) ; J  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 160;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( STR2 , (int)( J ) ) == 27))  ) ) 
                    { 
                    __context__.SourceCodeLine = 162;
                    RECEIVESTRING  .UpdateValue ( RECEIVESTRING + Functions.Chr (  (int) ( (Byte( STR2 , (int)( (J + 1) ) ) - 128) ) )  ) ; 
                    __context__.SourceCodeLine = 163;
                    J = (ushort) ( (J + 1) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 167;
                    RECEIVESTRING  .UpdateValue ( RECEIVESTRING + Functions.Chr (  (int) ( Byte( STR2 , (int)( J ) ) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 158;
                } 
            
            __context__.SourceCodeLine = 170;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( RECEIVESTRING , (int)( 1 ) ) == 6))  ) ) 
                { 
                __context__.SourceCodeLine = 172;
                RECEIVESTRING  .UpdateValue ( Functions.Right ( RECEIVESTRING ,  (int) ( (Functions.Length( RECEIVESTRING ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 170;
                } 
            
            __context__.SourceCodeLine = 174;
            return ( RECEIVESTRING ) ; 
            
            }
            
        object MUTE__DOLLAR___OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 182;
                MakeString ( STEMPSEND , "\u0088{0}\u0003{1}\u0000\u0001\u0000\u0000\u0000\u0001", SNODE , OBJECTID__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 183;
                TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
                __context__.SourceCodeLine = 185;
                if ( Functions.TestForTrue  ( ( SUBSCRIBE__DOLLAR__  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 187;
                    MakeString ( STEMPSEND , "\u0089{0}\u0003{1}\u0000\u0001\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ ) ; 
                    __context__.SourceCodeLine = 188;
                    TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
                    __context__.SourceCodeLine = 189;
                    Functions.ProcessLogic ( ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object UNMUTE__DOLLAR___OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 195;
            MakeString ( STEMPSEND , "\u0088{0}\u0003{1}\u0000\u0001\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 196;
            TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
            __context__.SourceCodeLine = 198;
            if ( Functions.TestForTrue  ( ( SUBSCRIBE__DOLLAR__  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 200;
                MakeString ( STEMPSEND , "\u0089{0}\u0003{1}\u0000\u0001\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 201;
                TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
                __context__.SourceCodeLine = 202;
                Functions.ProcessLogic ( ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object POLARITYON__DOLLAR___OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 209;
        MakeString ( STEMPSEND , "\u0088{0}\u0003{1}\u0000\u0002\u0000\u0000\u0000\u0001", SNODE , OBJECTID__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 210;
        TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
        __context__.SourceCodeLine = 212;
        if ( Functions.TestForTrue  ( ( SUBSCRIBE__DOLLAR__  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 214;
            MakeString ( STEMPSEND , "\u0089{0}\u0003{1}\u0000\u0002\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 215;
            TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
            __context__.SourceCodeLine = 216;
            Functions.ProcessLogic ( ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POLARITYOFF__DOLLAR___OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 223;
        MakeString ( STEMPSEND , "\u0088{0}\u0003{1}\u0000\u0002\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 224;
        TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
        __context__.SourceCodeLine = 226;
        if ( Functions.TestForTrue  ( ( SUBSCRIBE__DOLLAR__  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 228;
            MakeString ( STEMPSEND , "\u0089{0}\u0003{1}\u0000\u0002\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 229;
            TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
            __context__.SourceCodeLine = 230;
            Functions.ProcessLogic ( ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GAIN__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 237;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VOLUMEINPUT != GAIN__DOLLAR__  .UshortValue))  ) ) 
            { 
            __context__.SourceCodeLine = 239;
            if ( Functions.TestForTrue  ( ( XOKGAIN)  ) ) 
                { 
                __context__.SourceCodeLine = 241;
                XOKGAIN = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 242;
                VOLUMEINPUT = (ushort) ( GAIN__DOLLAR__  .UshortValue ) ; 
                __context__.SourceCodeLine = 243;
                GAIN_FB__DOLLAR__  .Value = (ushort) ( GAIN__DOLLAR__  .UshortValue ) ; 
                __context__.SourceCodeLine = 244;
                MakeString ( STEMPSEND , "\u008D{0}\u0003{1}\u0000\u0000{2}", SNODE , OBJECTID__DOLLAR__ , ITOVOLUMEPERCENT (  __context__ , (ushort)( GAIN__DOLLAR__  .UshortValue )) ) ; 
                __context__.SourceCodeLine = 245;
                TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
                __context__.SourceCodeLine = 246;
                XOKGAIN = (ushort) ( 1 ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUBSCRIBE__DOLLAR___OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 254;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_4__" , 20 , __SPLS_TMPVAR__WAITLABEL_4___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_4___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 256;
            if ( Functions.TestForTrue  ( ( XOKSUBSCRIBE)  ) ) 
                { 
                __context__.SourceCodeLine = 258;
                XOKSUBSCRIBE = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 259;
                MakeString ( STEMPSEND , "\u008E{0}\u0003{1}\u0000\u0000\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 260;
                TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
                __context__.SourceCodeLine = 261;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 262;
                MakeString ( STEMPSEND , "\u0089{0}\u0003{1}\u0000\u0001\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 263;
                TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
                __context__.SourceCodeLine = 264;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 265;
                MakeString ( STEMPSEND , "\u0089{0}\u0003{1}\u0000\u0002\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 266;
                TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
                __context__.SourceCodeLine = 267;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 268;
                XOKSUBSCRIBE = (ushort) ( 1 ) ; 
                } 
            
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object UNSUBSCRIBE__DOLLAR___OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 276;
        if ( Functions.TestForTrue  ( ( XOKSUBSCRIBE)  ) ) 
            { 
            __context__.SourceCodeLine = 278;
            XOKSUBSCRIBE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 279;
            MakeString ( STEMPSEND , "\u008F{0}\u0003{1}\u0000\u0000\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 280;
            TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
            __context__.SourceCodeLine = 281;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 282;
            MakeString ( STEMPSEND , "\u008A{0}\u0003{1}\u0000\u0001\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 283;
            TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
            __context__.SourceCodeLine = 284;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 285;
            MakeString ( STEMPSEND , "\u008A{0}\u0003{1}\u0000\u0002\u0000\u0000\u0000\u0000", SNODE , OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 286;
            TX__DOLLAR__  .UpdateValue ( SEND (  __context__ , STEMPSEND) + "\u0003\u0003\u0003\u0003"  ) ; 
            __context__.SourceCodeLine = 287;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 288;
            XOKSUBSCRIBE = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

private void PROCESSRXMESSAGE (  SplusExecutionContext __context__, CrestronString PARAMDATA ) 
    { 
    
    __context__.SourceCodeLine = 294;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "Send Name" , PARAMDATA ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 296;
        ITEMPNUM = (ushort) ( Functions.Atoi( PARAMDATA ) ) ; 
        __context__.SourceCodeLine = 297;
        IMARKER1 = (ushort) ( (Functions.Find( "Node " , PARAMDATA ) + 5) ) ; 
        __context__.SourceCodeLine = 298;
        SNODE  .UpdateValue ( Functions.Mid ( PARAMDATA ,  (int) ( IMARKER1 ) ,  (int) ( 2 ) )  ) ; 
        __context__.SourceCodeLine = 299;
        SOBJECTIDPADDED  .UpdateValue ( FPAD (  __context__ , OBJECTID__DOLLAR__ )  ) ; 
        __context__.SourceCodeLine = 300;
        MakeString ( TX__DOLLAR__ , "Send Name{0:d} = {1}\u0003\u0003\u0003\u0003\u0003", (short)ITEMPNUM, SOBJECTIDPADDED ) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 302;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( PARAMDATA , (int)( 7 ) , (int)( 3 ) ) == "\u0000\u0000\u0000") ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( PARAMDATA , (int)( 7 ) , (int)( Functions.Length( SOBJECTIDPADDED ) ) ) == SOBJECTIDPADDED) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 304;
            PARAMDATA  .UpdateValue ( FUNPAD (  __context__ , PARAMDATA)  ) ; 
            __context__.SourceCodeLine = 305;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)Byte( PARAMDATA , (int)( 10 ) ));
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 309;
                        VOLUMEINPUT = (ushort) ( VOLUMEPERCENTTOI( __context__ , Functions.Mid( PARAMDATA , (int)( 11 ) , (int)( 4 ) ) ) ) ; 
                        __context__.SourceCodeLine = 310;
                        GAIN_FB__DOLLAR__  .Value = (ushort) ( VOLUMEINPUT ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 314;
                        MUTE_FB__DOLLAR__  .Value = (ushort) ( Byte( PARAMDATA , (int)( 14 ) ) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 318;
                        POLARITY_FB__DOLLAR__  .Value = (ushort) ( Byte( PARAMDATA , (int)( 14 ) ) ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            } 
        
        }
    
    
    }
    
object RX__DOLLAR___OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 327;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 329;
            try 
                { 
                __context__.SourceCodeLine = 331;
                TEMPSTRING  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 332;
                TEMPSTRING  .UpdateValue ( Functions.Gather ( "\u0003\u0003\u0003\u0003\u0003" , RX__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 333;
                TEMPSTRING  .UpdateValue ( Functions.Left ( TEMPSTRING ,  (int) ( (Functions.Length( TEMPSTRING ) - 4) ) )  ) ; 
                __context__.SourceCodeLine = 334;
                PROCESSRXMESSAGE (  __context__ , TEMPSTRING) ; 
                } 
            
            catch (Exception __splus_exception__)
                { 
                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                
                __context__.SourceCodeLine = 338;
                GenerateUserNotice ( "BSS SoundWeb London Gain Error: {0}", Functions.GetExceptionMessage (  __splus_exceptionobj__ ) ) ; 
                
                }
                
                __context__.SourceCodeLine = 327;
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
        
        __context__.SourceCodeLine = 367;
        XOKGAIN = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 368;
        XOKSUBSCRIBE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 369;
        SUBSCRIBE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 370;
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    RETURNSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    SNODE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    STEMPSEND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    TEMPSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    SOBJECTIDPADDED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    SUBSCRIBE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( SUBSCRIBE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( SUBSCRIBE__DOLLAR____DigitalInput__, SUBSCRIBE__DOLLAR__ );
    
    UNSUBSCRIBE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( UNSUBSCRIBE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( UNSUBSCRIBE__DOLLAR____DigitalInput__, UNSUBSCRIBE__DOLLAR__ );
    
    MUTE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( MUTE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( MUTE__DOLLAR____DigitalInput__, MUTE__DOLLAR__ );
    
    UNMUTE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( UNMUTE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( UNMUTE__DOLLAR____DigitalInput__, UNMUTE__DOLLAR__ );
    
    POLARITYON__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( POLARITYON__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( POLARITYON__DOLLAR____DigitalInput__, POLARITYON__DOLLAR__ );
    
    POLARITYOFF__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( POLARITYOFF__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( POLARITYOFF__DOLLAR____DigitalInput__, POLARITYOFF__DOLLAR__ );
    
    MUTE_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_FB__DOLLAR____DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_FB__DOLLAR____DigitalOutput__, MUTE_FB__DOLLAR__ );
    
    POLARITY_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalOutput( POLARITY_FB__DOLLAR____DigitalOutput__, this );
    m_DigitalOutputList.Add( POLARITY_FB__DOLLAR____DigitalOutput__, POLARITY_FB__DOLLAR__ );
    
    GAIN__DOLLAR__ = new Crestron.Logos.SplusObjects.AnalogInput( GAIN__DOLLAR____AnalogSerialInput__, this );
    m_AnalogInputList.Add( GAIN__DOLLAR____AnalogSerialInput__, GAIN__DOLLAR__ );
    
    GAIN_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.AnalogOutput( GAIN_FB__DOLLAR____AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GAIN_FB__DOLLAR____AnalogSerialOutput__, GAIN_FB__DOLLAR__ );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( RX__DOLLAR____AnalogSerialInput__, 4000, this );
    m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
    
    OBJECTID__DOLLAR__ = new StringParameter( OBJECTID__DOLLAR____Parameter__, this );
    m_ParameterList.Add( OBJECTID__DOLLAR____Parameter__, OBJECTID__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_4___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_4___CallbackFn );
    
    MUTE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTE__DOLLAR___OnPush_0, false ) );
    UNMUTE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( UNMUTE__DOLLAR___OnPush_1, false ) );
    POLARITYON__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLARITYON__DOLLAR___OnPush_2, false ) );
    POLARITYOFF__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLARITYOFF__DOLLAR___OnPush_3, false ) );
    GAIN__DOLLAR__.OnAnalogChange.Add( new InputChangeHandlerWrapper( GAIN__DOLLAR___OnChange_4, false ) );
    SUBSCRIBE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUBSCRIBE__DOLLAR___OnPush_5, false ) );
    UNSUBSCRIBE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( UNSUBSCRIBE__DOLLAR___OnPush_6, false ) );
    RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_7, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BSS_SOUNDWEB_LONDON_GAIN_V5_4 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_4___Callback;


const uint SUBSCRIBE__DOLLAR____DigitalInput__ = 0;
const uint UNSUBSCRIBE__DOLLAR____DigitalInput__ = 1;
const uint MUTE__DOLLAR____DigitalInput__ = 2;
const uint UNMUTE__DOLLAR____DigitalInput__ = 3;
const uint POLARITYON__DOLLAR____DigitalInput__ = 4;
const uint POLARITYOFF__DOLLAR____DigitalInput__ = 5;
const uint GAIN__DOLLAR____AnalogSerialInput__ = 0;
const uint RX__DOLLAR____AnalogSerialInput__ = 1;
const uint MUTE_FB__DOLLAR____DigitalOutput__ = 0;
const uint POLARITY_FB__DOLLAR____DigitalOutput__ = 1;
const uint GAIN_FB__DOLLAR____AnalogSerialOutput__ = 0;
const uint TX__DOLLAR____AnalogSerialOutput__ = 1;
const uint OBJECTID__DOLLAR____Parameter__ = 10;

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
