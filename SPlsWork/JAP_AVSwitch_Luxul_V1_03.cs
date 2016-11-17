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

namespace UserModule_JAP_AVSWITCH_LUXUL_V1_03
{
    public class UserModuleClass_JAP_AVSWITCH_LUXUL_V1_03 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        private ushort _12 (  SplusExecutionContext __context__, ushort _14 ) 
            { 
            
            __context__.SourceCodeLine = 2;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _14 >= 64 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _14 <= 90 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _14 >= 96 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _14 <= 122 ) )) ) )) )) ; 
            
            }
            
        private ushort _13 (  SplusExecutionContext __context__, ushort _15 ) 
            { 
            
            __context__.SourceCodeLine = 2;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _15 < 32 ) ) || Functions.TestForTrue ( Functions.BoolToInt (_15 == 127) )) )) ; 
            
            }
            
        private ushort _14 (  SplusExecutionContext __context__, ushort _16 ) 
            { 
            
            __context__.SourceCodeLine = 2;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _16 >= 48 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _16 <= 57 ) )) )) ; 
            
            }
            
        private ushort _15 (  SplusExecutionContext __context__, ushort _17 ) 
            { 
            
            __context__.SourceCodeLine = 2;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _17 >= 96 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _17 <= 122 ) )) )) ; 
            
            }
            
        private ushort _16 (  SplusExecutionContext __context__, ushort _18 ) 
            { 
            
            __context__.SourceCodeLine = 3;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _18 >= 33 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _18 <= 47 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _18 >= 58 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _18 <= 64 ) )) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _18 >= 91 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _18 <= 96 ) )) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _18 >= 123 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _18 <= 126 ) )) ) )) )) ; 
            
            }
            
        private ushort _17 (  SplusExecutionContext __context__, ushort _19 ) 
            { 
            
            __context__.SourceCodeLine = 3;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_19 == 9) ) || Functions.TestForTrue ( Functions.BoolToInt (_19 == 10) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_19 == 13) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_19 == 32) )) )) ; 
            
            }
            
        private ushort _18 (  SplusExecutionContext __context__, ushort _20 ) 
            { 
            
            __context__.SourceCodeLine = 3;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _20 >= 64 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _20 <= 90 ) )) )) ; 
            
            }
            
        private ushort _19 (  SplusExecutionContext __context__, ushort _21 ) 
            { 
            
            __context__.SourceCodeLine = 3;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( _14( __context__ , (ushort)( _21 ) ) ) || Functions.TestForTrue ( _12( __context__ , (ushort)( _21 ) ) )) )) ; 
            
            }
            
        private ushort _20 (  SplusExecutionContext __context__, ushort _22 ) 
            { 
            
            __context__.SourceCodeLine = 3;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( _14( __context__ , (ushort)( _22 ) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _22 >= 65 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _22 <= 70 ) )) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _22 >= 97 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _22 <= 102 ) )) ) )) )) ; 
            
            }
            
        private ushort _21 (  SplusExecutionContext __context__, ref _0 _23 , ushort _24 , CrestronString _5 , ushort _25 ) 
            { 
            ushort _26 = 0;
            
            ushort _27 = 0;
            
            
            __context__.SourceCodeLine = 4;
            _23 . _5  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 4;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _5 ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _5 , (int)( 1 ) ) == 94) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 4;
                _26 = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 4;
                _25 = (ushort) ( (_25 - 1) ) ; 
                __context__.SourceCodeLine = 4;
                _23 . _5  .UpdateValue ( Functions.Right ( _5 ,  (int) ( _25 ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 4;
                _26 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 4;
                _23 . _5  .UpdateValue ( _5  ) ; 
                } 
            
            __context__.SourceCodeLine = 4;
            _23 . _1  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 4;
            _23 . _2 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 4;
            _23 . _6 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 4;
            _23 . _7 = (ushort) ( (_24 + 1) ) ; 
            __context__.SourceCodeLine = 4;
            _23 . _8 = (ushort) ( (_25 + 1) ) ; 
            __context__.SourceCodeLine = 4;
            _23 . _9 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 4;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)(10 - 1); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _27  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_27  >= __FN_FORSTART_VAL__1) && (_27  <= __FN_FOREND_VAL__1) ) : ( (_27  <= __FN_FORSTART_VAL__1) && (_27  >= __FN_FOREND_VAL__1) ) ; _27  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 4;
                _23 . _3 [ _27] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 4;
                _23 . _4 [ _27] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 4;
                _23 . _10 [ _27] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 4;
                _23 . _11 [ _27] = (short) ( 0 ) ; 
                __context__.SourceCodeLine = 4;
                } 
            
            __context__.SourceCodeLine = 4;
            return (ushort)( _26) ; 
            
            }
            
        private ushort _22 (  SplusExecutionContext __context__, ref _0 _24 , ushort _25 , CrestronString _26 ) 
            { 
            
            __context__.SourceCodeLine = 4;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_24._2 + _25) > 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 4;
                _25 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 4;
                _24 . _1  .UpdateValue ( _26  ) ; 
                } 
            
            __context__.SourceCodeLine = 4;
            return (ushort)( _25) ; 
            
            }
            
        private ushort _23 (  SplusExecutionContext __context__, ref _0 _25 , ushort _26 , ushort _27 ) 
            { 
            ushort _28 = 0;
            
            ushort _3 = 0;
            
            
            __context__.SourceCodeLine = 4;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _25._2 >= 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 4;
                _25 . _1  .UpdateValue ( "stack overflow"  ) ; 
                __context__.SourceCodeLine = 4;
                _28 = (ushort) ( 0 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 5;
                _3 = (ushort) ( ((_26 - _25._6) + 1) ) ; 
                __context__.SourceCodeLine = 5;
                _25 . _3 [ _25._2] = (ushort) ( _3 ) ; 
                __context__.SourceCodeLine = 5;
                _25 . _4 [ _25._2] = (ushort) ( (_3 + (_27 - _26)) ) ; 
                __context__.SourceCodeLine = 5;
                _25 . _2 = (ushort) ( (_25._2 + 1) ) ; 
                __context__.SourceCodeLine = 5;
                _28 = (ushort) ( 1 ) ; 
                } 
            
            __context__.SourceCodeLine = 5;
            return (ushort)( _28) ; 
            
            }
            
        private ushort _24 (  SplusExecutionContext __context__, ref _0 _26 , ushort _27 ) 
            { 
            
            __context__.SourceCodeLine = 5;
            _27 = (ushort) ( (_27 - 49) ) ; 
            __context__.SourceCodeLine = 5;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _27 < 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _27 >= _26._9 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_26._11[ _27 ] == Functions.ToSignedLongInteger( -( 1 ) )) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 5;
                _26 . _1  .UpdateValue ( "invalid capture index"  ) ; 
                __context__.SourceCodeLine = 5;
                _27 = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 5;
            return (ushort)( _27) ; 
            
            }
            
        private short _25 (  SplusExecutionContext __context__, ref _0 _27 ) 
            { 
            ushort _9 = 0;
            
            
            __context__.SourceCodeLine = 5;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( _27._9 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)0; 
            int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
            for ( _9  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_9  >= __FN_FORSTART_VAL__1) && (_9  <= __FN_FOREND_VAL__1) ) : ( (_9  <= __FN_FORSTART_VAL__1) && (_9  >= __FN_FOREND_VAL__1) ) ; _9  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 5;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_27._11[ _9 ] == Functions.ToSignedLongInteger( -( 1 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 5;
                    return (short)( _9) ; 
                    }
                
                __context__.SourceCodeLine = 5;
                } 
            
            __context__.SourceCodeLine = 5;
            _27 . _1  .UpdateValue ( "invalid pattern capture"  ) ; 
            __context__.SourceCodeLine = 5;
            return (short)( Functions.ToSignedInteger( -( 1 ) )) ; 
            
            }
            
        private ushort _26 (  SplusExecutionContext __context__, ref _0 _28 , ushort _29 ) 
            { 
            
            __context__.SourceCodeLine = 5;
            _29 = (ushort) ( (_29 + 1) ) ; 
            __context__.SourceCodeLine = 5;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)Byte( _28._5 , (int)( (_29 - 1) ) ));
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 37) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 6;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_29 == _28._8))  ) ) 
                            { 
                            __context__.SourceCodeLine = 6;
                            _28 . _1  .UpdateValue ( "malformed pattern (ends with %)"  ) ; 
                            __context__.SourceCodeLine = 6;
                            return (ushort)( _29) ; 
                            } 
                        
                        __context__.SourceCodeLine = 6;
                        return (ushort)( (_29 + 1)) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 91) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 6;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _29 < _28._8 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _28._5 , (int)( _29 ) ) == 94) )) ))  ) ) 
                            {
                            __context__.SourceCodeLine = 6;
                            _29 = (ushort) ( (_29 + 1) ) ; 
                            }
                        
                        __context__.SourceCodeLine = 6;
                        do 
                            { 
                            __context__.SourceCodeLine = 6;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_29 == _28._8))  ) ) 
                                { 
                                __context__.SourceCodeLine = 6;
                                _28 . _1  .UpdateValue ( "malformed pattern (missing ])"  ) ; 
                                __context__.SourceCodeLine = 6;
                                return (ushort)( _29) ; 
                                } 
                            
                            __context__.SourceCodeLine = 6;
                            _29 = (ushort) ( (_29 + 1) ) ; 
                            __context__.SourceCodeLine = 6;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( _28._5 , (int)( (_29 - 1) ) ) == 37) ) && Functions.TestForTrue ( Functions.BoolToInt ( _29 < _28._8 ) )) ))  ) ) 
                                {
                                __context__.SourceCodeLine = 6;
                                _29 = (ushort) ( (_29 + 1) ) ; 
                                }
                            
                            } 
                        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Byte( _28._5 , (int)( _29 ) ) == 93)) )); 
                        __context__.SourceCodeLine = 6;
                        return (ushort)( (_29 + 1)) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 6;
                        return (ushort)( _29) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort _27 (  SplusExecutionContext __context__, ushort _29 , ushort _30 ) 
            { 
            ushort _31 = 0;
            
            
            __context__.SourceCodeLine = 6;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)Functions.LowerChar( (uint)( _30 ) ));
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == (  (uint) ( 97 ) ) ) ) ) 
                        {
                        __context__.SourceCodeLine = 6;
                        _31 = (ushort) ( _12( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 99) ) ) ) 
                        {
                        __context__.SourceCodeLine = 6;
                        _31 = (ushort) ( _13( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 100) ) ) ) 
                        {
                        __context__.SourceCodeLine = 6;
                        _31 = (ushort) ( _14( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 108) ) ) ) 
                        {
                        __context__.SourceCodeLine = 7;
                        _31 = (ushort) ( _15( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 112) ) ) ) 
                        {
                        __context__.SourceCodeLine = 7;
                        _31 = (ushort) ( _16( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 115) ) ) ) 
                        {
                        __context__.SourceCodeLine = 7;
                        _31 = (ushort) ( _17( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 117) ) ) ) 
                        {
                        __context__.SourceCodeLine = 7;
                        _31 = (ushort) ( _18( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 119) ) ) ) 
                        {
                        __context__.SourceCodeLine = 7;
                        _31 = (ushort) ( _19( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 120) ) ) ) 
                        {
                        __context__.SourceCodeLine = 7;
                        _31 = (ushort) ( _20( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 122) ) ) ) 
                        {
                        __context__.SourceCodeLine = 7;
                        return (ushort)( Functions.BoolToInt (_29 == 0)) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 7;
                        return (ushort)( Functions.BoolToInt (_30 == _29)) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 7;
            if ( Functions.TestForTrue  ( ( _18( __context__ , (ushort)( _30 ) ))  ) ) 
                {
                __context__.SourceCodeLine = 7;
                _31 = (ushort) ( Functions.Not( _31 ) ) ; 
                }
            
            __context__.SourceCodeLine = 7;
            return (ushort)( _31) ; 
            
            }
            
        private ushort _28 (  SplusExecutionContext __context__, ref _0 _30 , ushort _31 , ushort _32 , ushort _33 ) 
            { 
            ushort _34 = 0;
            
            
            __context__.SourceCodeLine = 7;
            _34 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 7;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (_32 + 1) < _30._8 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _30._5 , (int)( (_32 + 1) ) ) == 94) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 7;
                _34 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 7;
                _32 = (ushort) ( (_32 + 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 7;
            _32 = (ushort) ( (_32 + 1) ) ; 
            __context__.SourceCodeLine = 7;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _32 < _33 ))  ) ) 
                { 
                __context__.SourceCodeLine = 7;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _30._5 , (int)( _32 ) ) == 37))  ) ) 
                    { 
                    __context__.SourceCodeLine = 7;
                    _32 = (ushort) ( (_32 + 1) ) ; 
                    __context__.SourceCodeLine = 7;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _32 < _30._8 ) ) && Functions.TestForTrue ( _27( __context__ , (ushort)( _31 ) , (ushort)( Byte( _30._5 , (int)( _32 ) ) ) ) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 7;
                        return (ushort)( _34) ; 
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 8;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (_32 + 1) < _30._8 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _30._5 , (int)( (_32 + 1) ) ) == 45) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (_32 + 2) < _33 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 8;
                        _32 = (ushort) ( (_32 + 2) ) ; 
                        __context__.SourceCodeLine = 8;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Byte( _30._5 , (int)( (_32 - 2) ) ) <= _31 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _31 <= Byte( _30._5 , (int)( _32 ) ) ) )) ))  ) ) 
                            {
                            __context__.SourceCodeLine = 8;
                            return (ushort)( _34) ; 
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 8;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _30._5 , (int)( _32 ) ) == _31))  ) ) 
                            {
                            __context__.SourceCodeLine = 8;
                            return (ushort)( _34) ; 
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 8;
                _32 = (ushort) ( (_32 + 1) ) ; 
                __context__.SourceCodeLine = 7;
                } 
            
            __context__.SourceCodeLine = 8;
            return (ushort)( Functions.Not( _34 )) ; 
            
            }
            
        private ushort _29 (  SplusExecutionContext __context__, ref _0 _31 , ushort _32 , ushort _33 , ushort _34 ) 
            { 
            
            __context__.SourceCodeLine = 8;
            
                {
                int __SPLS_TMPVAR__SWTCH_3__ = ((int)Byte( _31._5 , (int)( _33 ) ));
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 46) ) ) ) 
                        {
                        __context__.SourceCodeLine = 8;
                        return (ushort)( 1) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 37) ) ) ) 
                        {
                        __context__.SourceCodeLine = 8;
                        return (ushort)( _27( __context__ , (ushort)( _32 ) , (ushort)( Byte( _31._5 , (int)( (_33 + 1) ) ) ) )) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 91) ) ) ) 
                        {
                        __context__.SourceCodeLine = 8;
                        return (ushort)( _28( __context__ , ref _31 , (ushort)( _32 ) , (ushort)( _33 ) , (ushort)( (_34 - 1) ) )) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 8;
                        return (ushort)( Functions.BoolToInt (Byte( _31._5 , (int)( _33 ) ) == _32)) ; 
                        }
                    
                    } 
                    
                }
                
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort _30 (  SplusExecutionContext __context__, ref _0 _32 , CrestronString _33 , ushort _34 , ushort _35 ) 
            { 
            ushort _36 = 0;
            
            ushort _37 = 0;
            
            ushort _38 = 0;
            
            
            __context__.SourceCodeLine = 9;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _35 >= (_32._8 - 1) ))  ) ) 
                { 
                __context__.SourceCodeLine = 9;
                _32 . _1  .UpdateValue ( "malformed pattern (missing arguments to %b)"  ) ; 
                __context__.SourceCodeLine = 9;
                return (ushort)( 0) ; 
                } 
            
            __context__.SourceCodeLine = 9;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _33 , (int)( _34 ) ) != Byte( _32._5 , (int)( _35 ) )))  ) ) 
                {
                __context__.SourceCodeLine = 9;
                return (ushort)( 0) ; 
                }
            
            else 
                { 
                __context__.SourceCodeLine = 9;
                _36 = (ushort) ( Byte( _32._5 , (int)( _35 ) ) ) ; 
                __context__.SourceCodeLine = 9;
                _37 = (ushort) ( Byte( _32._5 , (int)( (_35 + 1) ) ) ) ; 
                __context__.SourceCodeLine = 9;
                _38 = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 9;
                _34 = (ushort) ( (_34 + 1) ) ; 
                __context__.SourceCodeLine = 9;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _34 < _32._7 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 9;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _33 , (int)( _34 ) ) == _37))  ) ) 
                        { 
                        __context__.SourceCodeLine = 9;
                        _38 = (ushort) ( (_38 - 1) ) ; 
                        __context__.SourceCodeLine = 9;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_38 == 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 9;
                            return (ushort)( (_34 + 1)) ; 
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 9;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _33 , (int)( _34 ) ) == _36))  ) ) 
                            {
                            __context__.SourceCodeLine = 9;
                            _38 = (ushort) ( (_38 + 1) ) ; 
                            }
                        
                        }
                    
                    __context__.SourceCodeLine = 9;
                    _34 = (ushort) ( (_34 + 1) ) ; 
                    __context__.SourceCodeLine = 9;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 9;
            return (ushort)( 0) ; 
            
            }
            
        private ushort _31 (  SplusExecutionContext __context__, ref _0 _33 , CrestronString _34 , ushort _35 , ushort _36 ) 
            { 
            ushort _11 = 0;
            
            
            __context__.SourceCodeLine = 10;
            _36 = (ushort) ( _24( __context__ , ref _33 , (ushort)( _36 ) ) ) ; 
            __context__.SourceCodeLine = 10;
            _11 = (ushort) ( _33._11[ _36 ] ) ; 
            __context__.SourceCodeLine = 10;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (_33._7 - _35) >= _11 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( _34 , (int)( _33._10[ _36 ] ) , (int)( _11 ) ) == Functions.Mid( _34 , (int)( _35 ) , (int)( _11 ) )) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 10;
                return (ushort)( (_35 + _11)) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 10;
                return (ushort)( 0) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort _32 (  SplusExecutionContext __context__, ref _0 _34 , CrestronString _35 , ushort _36 , ushort _37 ) 
            { 
            ushort _38 = 0;
            
            ushort _39 = 0;
            
            short _40 = 0;
            
            ushort _41 = 0;
            
            ushort _42 = 0;
            
            short _43 = 0;
            
            ushort _44 = 0;
            
            
            __context__.SourceCodeLine = 10;
            while ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 10;
                _41 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 10;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_37 == _34._8))  ) ) 
                    { 
                    __context__.SourceCodeLine = 10;
                    return (ushort)( _36) ; 
                    } 
                
                __context__.SourceCodeLine = 10;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_4__ = ((int)Byte( _34._5 , (int)( _37 ) ));
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 40) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 10;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _34._5 , (int)( (_37 + 1) ) ) == 41))  ) ) 
                                { 
                                __context__.SourceCodeLine = 10;
                                _40 = (short) ( Functions.ToSignedInteger( -( 2 ) ) ) ; 
                                __context__.SourceCodeLine = 10;
                                _37 = (ushort) ( (_37 + 2) ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 10;
                                _40 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                                __context__.SourceCodeLine = 10;
                                _37 = (ushort) ( (_37 + 1) ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 10;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _34._9 >= 10 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 10;
                                _34 . _1  .UpdateValue ( "too many captures"  ) ; 
                                __context__.SourceCodeLine = 10;
                                return (ushort)( 0) ; 
                                } 
                            
                            __context__.SourceCodeLine = 11;
                            _34 . _10 [ _34._9] = (ushort) ( _36 ) ; 
                            __context__.SourceCodeLine = 11;
                            _34 . _11 [ _34._9] = (short) ( _40 ) ; 
                            __context__.SourceCodeLine = 11;
                            _34 . _9 = (ushort) ( (_34._9 + 1) ) ; 
                            __context__.SourceCodeLine = 11;
                            _44 = (ushort) ( _32( __context__ , ref _34 , _35 , (ushort)( _36 ) , (ushort)( _37 ) ) ) ; 
                            __context__.SourceCodeLine = 11;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_44 == 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 11;
                                _34 . _9 = (ushort) ( (_34._9 - 1) ) ; 
                                }
                            
                            __context__.SourceCodeLine = 11;
                            return (ushort)( _44) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 41) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 11;
                            _43 = (short) ( _25( __context__ , ref _34 ) ) ; 
                            __context__.SourceCodeLine = 11;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _43 < 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 11;
                                return (ushort)( 0) ; 
                                }
                            
                            __context__.SourceCodeLine = 11;
                            _34 . _11 [ _43] = (short) ( (_36 - _34._10[ _43 ]) ) ; 
                            __context__.SourceCodeLine = 11;
                            _44 = (ushort) ( _32( __context__ , ref _34 , _35 , (ushort)( _36 ) , (ushort)( (_37 + 1) ) ) ) ; 
                            __context__.SourceCodeLine = 11;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_44 == 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 11;
                                _34 . _11 [ _43] = (short) ( Functions.ToInteger( -( 1 ) ) ) ; 
                                }
                            
                            __context__.SourceCodeLine = 11;
                            return (ushort)( _44) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 36) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 11;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((_37 + 1) == _34._8))  ) ) 
                                { 
                                __context__.SourceCodeLine = 11;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_36 == _34._7))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 11;
                                    return (ushort)( _36) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 11;
                                    return (ushort)( 0) ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 37) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 11;
                            
                                {
                                int __SPLS_TMPVAR__SWTCH_5__ = ((int)Byte( _34._5 , (int)( (_37 + 1) ) ));
                                
                                    { 
                                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 98) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 11;
                                        _36 = (ushort) ( _30( __context__ , ref _34 , _35 , (ushort)( _36 ) , (ushort)( (_37 + 2) ) ) ) ; 
                                        __context__.SourceCodeLine = 11;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_36 == 0))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 11;
                                            return (ushort)( 0) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 11;
                                        _37 = (ushort) ( (_37 + 4) ) ; 
                                        __context__.SourceCodeLine = 11;
                                        _41 = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 102) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 11;
                                        _37 = (ushort) ( (_37 + 2) ) ; 
                                        __context__.SourceCodeLine = 11;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _34._5 , (int)( _37 ) ) != 91))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 12;
                                            _34 . _1  .UpdateValue ( "missing [ after %f in pattern"  ) ; 
                                            __context__.SourceCodeLine = 12;
                                            return (ushort)( 0) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 12;
                                        _38 = (ushort) ( _26( __context__ , ref _34 , (ushort)( _37 ) ) ) ; 
                                        __context__.SourceCodeLine = 12;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_36 == _34._6))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 12;
                                            _39 = (ushort) ( 0 ) ; 
                                            }
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 12;
                                            _39 = (ushort) ( Byte( _35 , (int)( (_36 - 1) ) ) ) ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 12;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( _28( __context__ , ref _34 , (ushort)( _39 ) , (ushort)( _37 ) , (ushort)( (_38 - 1) ) ) ) || Functions.TestForTrue ( Functions.Not( _28( __context__ , ref _34 , (ushort)( Byte( _35 , (int)( _36 ) ) ) , (ushort)( _37 ) , (ushort)( (_38 - 1) ) ) ) )) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 12;
                                            return (ushort)( 0) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 12;
                                        _37 = (ushort) ( _38 ) ; 
                                        __context__.SourceCodeLine = 12;
                                        _41 = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 12;
                                        if ( Functions.TestForTrue  ( ( _14( __context__ , (ushort)( Byte( _34._5 , (int)( (_37 + 1) ) ) ) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 12;
                                            _36 = (ushort) ( _31( __context__ , ref _34 , _35 , (ushort)( _36 ) , (ushort)( Byte( _34._5 , (int)( (_37 + 1) ) ) ) ) ) ; 
                                            __context__.SourceCodeLine = 12;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_36 == 0))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 12;
                                                return (ushort)( 0) ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 12;
                                            _37 = (ushort) ( (_37 + 2) ) ; 
                                            __context__.SourceCodeLine = 12;
                                            _41 = (ushort) ( 1 ) ; 
                                            } 
                                        
                                        } 
                                    
                                    } 
                                    
                                }
                                
                            
                            } 
                        
                        else 
                            { 
                            } 
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 12;
                if ( Functions.TestForTrue  ( ( Functions.Not( _41 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 12;
                    _38 = (ushort) ( _26( __context__ , ref _34 , (ushort)( _37 ) ) ) ; 
                    __context__.SourceCodeLine = 12;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _36 < _34._7 ) ) && Functions.TestForTrue ( _29( __context__ , ref _34 , (ushort)( Byte( _35 , (int)( _36 ) ) ) , (ushort)( _37 ) , (ushort)( _38 ) ) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 12;
                        _40 = (short) ( 1 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 12;
                        _40 = (short) ( 0 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 12;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _38 >= _34._8 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 12;
                        _42 = (ushort) ( 0 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 12;
                        _42 = (ushort) ( Byte( _34._5 , (int)( _38 ) ) ) ; 
                        }
                    
                    __context__.SourceCodeLine = 12;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_42 == 63))  ) ) 
                        { 
                        __context__.SourceCodeLine = 12;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_40 != 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 13;
                            _40 = (short) ( _32( __context__ , ref _34 , _35 , (ushort)( (_36 + 1) ) , (ushort)( (_38 + 1) ) ) ) ; 
                            __context__.SourceCodeLine = 13;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_40 != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 13;
                                return (ushort)( _40) ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 13;
                        _37 = (ushort) ( (_38 + 1) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 13;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_42 == 42) ) || Functions.TestForTrue ( Functions.BoolToInt (_42 == 43) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 13;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_42 == 43))  ) ) 
                                { 
                                __context__.SourceCodeLine = 13;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_40 == 0))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 13;
                                    return (ushort)( 0) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 13;
                                    _36 = (ushort) ( (_36 + 1) ) ; 
                                    }
                                
                                } 
                            
                            __context__.SourceCodeLine = 13;
                            _43 = (short) ( 0 ) ; 
                            __context__.SourceCodeLine = 13;
                            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (_36 + _43) < _34._7 ) ) && Functions.TestForTrue ( _29( __context__ , ref _34 , (ushort)( Byte( _35 , (int)( (_36 + _43) ) ) ) , (ushort)( _37 ) , (ushort)( _38 ) ) )) ))  ) ) 
                                {
                                __context__.SourceCodeLine = 13;
                                _43 = (short) ( (_43 + 1) ) ; 
                                __context__.SourceCodeLine = 13;
                                }
                            
                            __context__.SourceCodeLine = 13;
                            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _43 >= 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 13;
                                _44 = (ushort) ( _32( __context__ , ref _34 , _35 , (ushort)( (_36 + _43) ) , (ushort)( (_38 + 1) ) ) ) ; 
                                __context__.SourceCodeLine = 13;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _44 > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 13;
                                    return (ushort)( _44) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 13;
                                _43 = (short) ( (_43 - 1) ) ; 
                                __context__.SourceCodeLine = 13;
                                } 
                            
                            __context__.SourceCodeLine = 13;
                            return (ushort)( 0) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 13;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_42 == 45))  ) ) 
                                { 
                                __context__.SourceCodeLine = 13;
                                while ( Functions.TestForTrue  ( ( 1)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 13;
                                    _44 = (ushort) ( _32( __context__ , ref _34 , _35 , (ushort)( _36 ) , (ushort)( (_38 + 1) ) ) ) ; 
                                    __context__.SourceCodeLine = 13;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_44 != 0))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 13;
                                        return (ushort)( _44) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 13;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _36 < _34._7 ) ) && Functions.TestForTrue ( _29( __context__ , ref _34 , (ushort)( Byte( _35 , (int)( _36 ) ) ) , (ushort)( _37 ) , (ushort)( _38 ) ) )) ))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 13;
                                            _36 = (ushort) ( (_36 + 1) ) ; 
                                            }
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 13;
                                            return (ushort)( 0) ; 
                                            } 
                                        
                                        }
                                    
                                    __context__.SourceCodeLine = 13;
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 13;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_40 == 0))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 13;
                                    return (ushort)( 0) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 13;
                                _36 = (ushort) ( (_36 + 1) ) ; 
                                __context__.SourceCodeLine = 14;
                                _37 = (ushort) ( _38 ) ; 
                                } 
                            
                            }
                        
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 10;
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort _33 (  SplusExecutionContext __context__, ref _0 _35 , ushort _36 , ushort _37 , ushort _38 ) 
            { 
            ushort _39 = 0;
            
            short _40 = 0;
            
            
            __context__.SourceCodeLine = 14;
            _39 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 14;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _36 >= _35._9 ))  ) ) 
                { 
                __context__.SourceCodeLine = 14;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_36 == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 14;
                    _39 = (ushort) ( _23( __context__ , ref _35 , (ushort)( _37 ) , (ushort)( _38 ) ) ) ; 
                    }
                
                else 
                    { 
                    __context__.SourceCodeLine = 14;
                    _35 . _1  .UpdateValue ( "invalid capture index"  ) ; 
                    __context__.SourceCodeLine = 14;
                    _39 = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 14;
                _40 = (short) ( _35._11[ _36 ] ) ; 
                __context__.SourceCodeLine = 14;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_40 == Functions.ToSignedLongInteger( -( 1 ) )))  ) ) 
                    { 
                    __context__.SourceCodeLine = 14;
                    _35 . _1  .UpdateValue ( "unfinished capture"  ) ; 
                    __context__.SourceCodeLine = 14;
                    _39 = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 14;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_40 == Functions.ToSignedLongInteger( -( 2 ) )))  ) ) 
                        {
                        __context__.SourceCodeLine = 14;
                        _40 = (short) ( 0 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 14;
                    _39 = (ushort) ( _23( __context__ , ref _35 , (ushort)( _35._10[ _36 ] ) , (ushort)( (_35._10[ _36 ] + _40) ) ) ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 14;
            return (ushort)( _39) ; 
            
            }
            
        private ushort _34 (  SplusExecutionContext __context__, ref _0 _36 , ushort _37 , ushort _38 ) 
            { 
            ushort _39 = 0;
            
            ushort _40 = 0;
            
            
            __context__.SourceCodeLine = 14;
            _39 = (ushort) ( _22( __context__ , ref _36 , (ushort)( (_36._9 + 1) ) , "too many captures" ) ) ; 
            __context__.SourceCodeLine = 14;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _39 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 15;
                _23 (  __context__ ,   ref  _36 , (ushort)( _37 ), (ushort)( _38 )) ; 
                __context__.SourceCodeLine = 15;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)(_39 - 2); 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( _40  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_40  >= __FN_FORSTART_VAL__1) && (_40  <= __FN_FOREND_VAL__1) ) : ( (_40  <= __FN_FORSTART_VAL__1) && (_40  >= __FN_FOREND_VAL__1) ) ; _40  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 15;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_33( __context__ , ref _36 , (ushort)( _40 ) , (ushort)( _37 ) , (ushort)( _38 ) ) == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 15;
                        _39 = (ushort) ( _40 ) ; 
                        __context__.SourceCodeLine = 15;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 15;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 15;
            return (ushort)( _39) ; 
            
            }
            
        private short _35 (  SplusExecutionContext __context__, CrestronString _37 , ushort _38 , ushort _39 , CrestronString _40 , ushort _41 , ushort _42 ) 
            { 
            
            __context__.SourceCodeLine = 15;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_39 + _42) <= _38 ))  ) ) 
                { 
                __context__.SourceCodeLine = 15;
                _37  .UpdateValue ( Functions.Left ( _37 ,  (int) ( _39 ) ) + Functions.Mid ( _40 ,  (int) ( _41 ) ,  (int) ( _42 ) )  ) ; 
                __context__.SourceCodeLine = 15;
                return (short)( (_39 + _42)) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 15;
                _37  .UpdateValue ( "buffer overflow"  ) ; 
                __context__.SourceCodeLine = 15;
                return (short)( Functions.ToSignedInteger( -( 15 ) )) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private short _36 (  SplusExecutionContext __context__, ref _0 _38 , CrestronString _39 , ushort _40 , ushort _41 , CrestronString _42 , ushort _43 , ushort _44 , CrestronString _45 , ushort _46 ) 
            { 
            short _47 = 0;
            
            ushort _48 = 0;
            
            ushort _49 = 0;
            
            
            __context__.SourceCodeLine = 15;
            _47 = (short) ( _41 ) ; 
            __context__.SourceCodeLine = 15;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_46; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _48  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_48  >= __FN_FORSTART_VAL__1) && (_48  <= __FN_FOREND_VAL__1) ) : ( (_48  <= __FN_FORSTART_VAL__1) && (_48  >= __FN_FOREND_VAL__1) ) ; _48  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 16;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _45 , (int)( _48 ) ) != 37))  ) ) 
                    {
                    __context__.SourceCodeLine = 16;
                    _47 = (short) ( _35( __context__ , _39 , (ushort)( _40 ) , (ushort)( _41 ) , _45 , (ushort)( _48 ) , (ushort)( 1 ) ) ) ; 
                    }
                
                else 
                    { 
                    __context__.SourceCodeLine = 16;
                    _48 = (ushort) ( (_48 + 1) ) ; 
                    __context__.SourceCodeLine = 16;
                    _49 = (ushort) ( Byte( _45 , (int)( _48 ) ) ) ; 
                    __context__.SourceCodeLine = 16;
                    if ( Functions.TestForTrue  ( ( Functions.Not( _14( __context__ , (ushort)( _49 ) ) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 16;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_49 == 37))  ) ) 
                            {
                            __context__.SourceCodeLine = 16;
                            _47 = (short) ( _35( __context__ , _39 , (ushort)( _40 ) , (ushort)( _41 ) , _45 , (ushort)( _48 ) , (ushort)( 1 ) ) ) ; 
                            }
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 16;
                            _39  .UpdateValue ( "invalid use of %c in replacement string"  ) ; 
                            __context__.SourceCodeLine = 16;
                            _47 = (short) ( Functions.ToSignedInteger( -( Functions.Length( _39 ) ) ) ) ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 16;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_49 == 48))  ) ) 
                            {
                            __context__.SourceCodeLine = 16;
                            _47 = (short) ( _35( __context__ , _39 , (ushort)( _40 ) , (ushort)( _41 ) , _42 , (ushort)( _43 ) , (ushort)( (_44 - _43) ) ) ) ; 
                            }
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 16;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_33( __context__ , ref _38 , (ushort)( (_49 - 49) ) , (ushort)( _43 ) , (ushort)( _44 ) ) == 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 16;
                                _39  .UpdateValue ( _38 . _1  ) ; 
                                __context__.SourceCodeLine = 16;
                                _47 = (short) ( Functions.ToSignedInteger( -( Functions.Length( _39 ) ) ) ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 16;
                                _47 = (short) ( _35( __context__ , _39 , (ushort)( _40 ) , (ushort)( _41 ) , _42 , (ushort)( ((_38._6 + _38._3[ (_38._2 - 1) ]) - 1) ) , (ushort)( (_38._4[ (_38._2 - 1) ] - _38._3[ (_38._2 - 1) ]) ) ) ) ; 
                                __context__.SourceCodeLine = 16;
                                _38 . _2 = (ushort) ( (_38._2 - 1) ) ; 
                                } 
                            
                            } 
                        
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 16;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _47 < 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 16;
                    break ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 16;
                    _41 = (ushort) ( _47 ) ; 
                    }
                
                __context__.SourceCodeLine = 15;
                } 
            
            __context__.SourceCodeLine = 16;
            return (short)( _47) ; 
            
            }
            
        private ushort _37 (  SplusExecutionContext __context__, CrestronString _39 , ushort _40 , short _41 , CrestronString _5 , ushort _42 , ref _0 _43 ) 
            { 
            ushort _44 = 0;
            
            ushort _45 = 0;
            
            ushort _46 = 0;
            
            
            __context__.SourceCodeLine = 17;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _41 < 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 17;
                _41 = (short) ( ((_40 + _41) + 1) ) ; 
                }
            
            __context__.SourceCodeLine = 17;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _41 < 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 17;
                _41 = (short) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 17;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _41 > (_40 + 1) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 17;
                    _41 = (short) ( (_40 + 1) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 17;
            _45 = (ushort) ( _41 ) ; 
            __context__.SourceCodeLine = 17;
            _44 = (ushort) ( _21( __context__ , ref _43 , (ushort)( _40 ) , _5 , (ushort)( _42 ) ) ) ; 
            __context__.SourceCodeLine = 17;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _45 < _43._7 ))  ) ) 
                { 
                __context__.SourceCodeLine = 17;
                do 
                    { 
                    __context__.SourceCodeLine = 17;
                    _43 . _9 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 17;
                    _46 = (ushort) ( _32( __context__ , ref _43 , _39 , (ushort)( _45 ) , (ushort)( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 17;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_46 != 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 17;
                        return (ushort)( _34( __context__ , ref _43 , (ushort)( _45 ) , (ushort)( _46 ) )) ; 
                        }
                    
                    __context__.SourceCodeLine = 17;
                    _45 = (ushort) ( (_45 + 1) ) ; 
                    } 
                while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _45 >= _43._7 ) ) || Functions.TestForTrue ( _44 )) )) )); 
                } 
            
            __context__.SourceCodeLine = 17;
            return (ushort)( 0) ; 
            
            }
            
        private ushort _38 (  SplusExecutionContext __context__, CrestronString _40 , short _41 , CrestronString _5 , ref _0 _42 ) 
            { 
            
            __context__.SourceCodeLine = 17;
            return (ushort)( _37( __context__ , _40 , (ushort)( Functions.Length( _40 ) ) , (short)( _41 ) , _5 , (ushort)( Functions.Length( _5 ) ) , ref _42 )) ; 
            
            }
            
        private short _39 (  SplusExecutionContext __context__, CrestronString _41 , ushort _42 , short _43 , CrestronString _5 , ushort _44 , CrestronString _45 , ushort REPLEN , short REPCOUNT , CrestronString BUFFER , ref ushort BUFFERLEN ) 
            { 
            ushort _46 = 0;
            
            short _47 = 0;
            
            short _48 = 0;
            
            ushort _49 = 0;
            
            ushort _50 = 0;
            
            _0 _51;
            _51  = new _0( this, true );
            _51 .PopulateCustomAttributeList( false );
            
            
            __context__.SourceCodeLine = 18;
            _47 = (short) ( 0 ) ; 
            __context__.SourceCodeLine = 18;
            _48 = (short) ( 0 ) ; 
            __context__.SourceCodeLine = 18;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( REPCOUNT <= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 18;
                REPCOUNT = (short) ( (_42 + 1) ) ; 
                }
            
            __context__.SourceCodeLine = 18;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _43 < 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 18;
                _43 = (short) ( ((_42 + _43) + 1) ) ; 
                }
            
            __context__.SourceCodeLine = 18;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _43 < 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 18;
                _43 = (short) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 18;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _43 > (_42 + 1) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 18;
                    _43 = (short) ( (_42 + 1) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 18;
            BUFFER  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 18;
            _49 = (ushort) ( _43 ) ; 
            __context__.SourceCodeLine = 18;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _49 > 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 18;
                _48 = (short) ( _35( __context__ , BUFFER , (ushort)( BUFFERLEN ) , (ushort)( _48 ) , _41 , (ushort)( 1 ) , (ushort)( (_49 - 1) ) ) ) ; 
                }
            
            __context__.SourceCodeLine = 18;
            _46 = (ushort) ( _21( __context__ , ref _51 , (ushort)( _42 ) , _5 , (ushort)( _44 ) ) ) ; 
            __context__.SourceCodeLine = 18;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _47 < REPCOUNT ))  ) ) 
                { 
                __context__.SourceCodeLine = 18;
                _51 . _9 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 18;
                _51 . _2 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 19;
                _50 = (ushort) ( _32( __context__ , ref _51 , _41 , (ushort)( _49 ) , (ushort)( 1 ) ) ) ; 
                __context__.SourceCodeLine = 19;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( _51._1 ) != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 19;
                    _48 = (short) ( Functions.Length( _51._1 ) ) ; 
                    __context__.SourceCodeLine = 19;
                    BUFFER  .UpdateValue ( _51 . _1  ) ; 
                    __context__.SourceCodeLine = 19;
                    _47 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 19;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 19;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_50 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 19;
                    _47 = (short) ( (_47 + 1) ) ; 
                    __context__.SourceCodeLine = 19;
                    _48 = (short) ( _36( __context__ , ref _51 , BUFFER , (ushort)( BUFFERLEN ) , (ushort)( _48 ) , _41 , (ushort)( _49 ) , (ushort)( _50 ) , _45 , (ushort)( REPLEN ) ) ) ; 
                    __context__.SourceCodeLine = 19;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _48 < 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 19;
                        _47 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                        __context__.SourceCodeLine = 19;
                        _48 = (short) ( Functions.ToSignedInteger( -( _48 ) ) ) ; 
                        __context__.SourceCodeLine = 19;
                        break ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 19;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _50 > _49 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 19;
                    _49 = (ushort) ( _50 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 19;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _49 < _51._7 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 19;
                        _48 = (short) ( _35( __context__ , BUFFER , (ushort)( BUFFERLEN ) , (ushort)( _48 ) , _41 , (ushort)( _49 ) , (ushort)( 1 ) ) ) ; 
                        __context__.SourceCodeLine = 19;
                        _49 = (ushort) ( (_49 + 1) ) ; 
                        __context__.SourceCodeLine = 19;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _48 < 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 19;
                            _47 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                            __context__.SourceCodeLine = 19;
                            _48 = (short) ( Functions.ToSignedInteger( -( _48 ) ) ) ; 
                            __context__.SourceCodeLine = 19;
                            break ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 19;
                        break ; 
                        }
                    
                    }
                
                __context__.SourceCodeLine = 19;
                if ( Functions.TestForTrue  ( ( _46)  ) ) 
                    {
                    __context__.SourceCodeLine = 19;
                    break ; 
                    }
                
                __context__.SourceCodeLine = 18;
                } 
            
            __context__.SourceCodeLine = 19;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _47 >= 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 19;
                _48 = (short) ( _35( __context__ , BUFFER , (ushort)( BUFFERLEN ) , (ushort)( _48 ) , _41 , (ushort)( _49 ) , (ushort)( (_51._7 - _49) ) ) ) ; 
                __context__.SourceCodeLine = 19;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _48 < 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 19;
                    _47 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 19;
                    _48 = (short) ( Functions.ToSignedInteger( -( _48 ) ) ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 19;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _48 < BUFFERLEN ))  ) ) 
                        { 
                        } 
                    
                    }
                
                } 
            
            __context__.SourceCodeLine = 19;
            BUFFERLEN = (ushort) ( _48 ) ; 
            __context__.SourceCodeLine = 19;
            return (short)( _47) ; 
            
            }
            
        private short _40 (  SplusExecutionContext __context__, CrestronString _42 , short _43 , CrestronString _5 , CrestronString _44 , short _45 , CrestronString BUFFER , ref ushort BUFFERLEN ) 
            { 
            
            __context__.SourceCodeLine = 20;
            return (short)( _39( __context__ , _42 , (ushort)( Functions.Length( _42 ) ) , (short)( _43 ) , _5 , (ushort)( Functions.Length( _5 ) ) , _44 , (ushort)( Functions.Length( _44 ) ) , (short)( _45 ) , BUFFER , ref BUFFERLEN )) ; 
            
            }
            
        private ushort _48 (  SplusExecutionContext __context__, ref _41 _50 ) 
            { 
            ushort _51 = 0;
            
            
            __context__.SourceCodeLine = 20;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_50._45 == _50._44) ) && Functions.TestForTrue ( Functions.BoolToInt (_50._47 == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 20;
                _51 = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 20;
                _51 = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 20;
            return (ushort)( _51) ; 
            
            }
            
        private ushort _49 (  SplusExecutionContext __context__, ref _41 _51 ) 
            { 
            
            __context__.SourceCodeLine = 20;
            return (ushort)( _48( __context__ , ref _51 )) ; 
            
            }
            
        private ushort _50 (  SplusExecutionContext __context__, ref _41 _52 ) 
            { 
            ushort _53 = 0;
            
            
            __context__.SourceCodeLine = 21;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_52._45 == _52._44) ) && Functions.TestForTrue ( Functions.BoolToInt (_52._47 != 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 21;
                _53 = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 21;
                _53 = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 21;
            return (ushort)( _53) ; 
            
            }
            
        private ushort _51 (  SplusExecutionContext __context__, ref _41 _53 ) 
            { 
            ushort _54 = 0;
            
            
            __context__.SourceCodeLine = 21;
            if ( Functions.TestForTrue  ( ( _48( __context__ , ref _53 ))  ) ) 
                { 
                __context__.SourceCodeLine = 21;
                _54 = (ushort) ( _53._46 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 21;
                _54 = (ushort) ( _53._44 ) ; 
                } 
            
            __context__.SourceCodeLine = 21;
            return (ushort)( _54) ; 
            
            }
            
        private ushort _52 (  SplusExecutionContext __context__, ref _41 _54 ) 
            { 
            ushort _55 = 0;
            
            
            __context__.SourceCodeLine = 21;
            if ( Functions.TestForTrue  ( ( _48( __context__ , ref _54 ))  ) ) 
                { 
                __context__.SourceCodeLine = 21;
                _55 = (ushort) ( _54._46 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 21;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_54._45 == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 21;
                    _55 = (ushort) ( (_54._46 - 1) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 21;
                    _55 = (ushort) ( (_54._45 - 1) ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 21;
            return (ushort)( _55) ; 
            
            }
            
        private ushort _53 (  SplusExecutionContext __context__, ref _41 _55 ) 
            { 
            
            __context__.SourceCodeLine = 21;
            return (ushort)( _51( __context__ , ref _55 )) ; 
            
            }
            
        private ushort _54 (  SplusExecutionContext __context__, ref _41 _56 ) 
            { 
            
            __context__.SourceCodeLine = 21;
            return (ushort)( _52( __context__ , ref _56 )) ; 
            
            }
            
        private ushort _55 (  SplusExecutionContext __context__, ref _41 _57 ) 
            { 
            ushort _58 = 0;
            
            
            __context__.SourceCodeLine = 21;
            if ( Functions.TestForTrue  ( ( _50( __context__ , ref _57 ))  ) ) 
                { 
                __context__.SourceCodeLine = 21;
                _58 = (ushort) ( _57._46 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 22;
                _58 = (ushort) ( _57._45 ) ; 
                __context__.SourceCodeLine = 22;
                _57 . _45 = (ushort) ( (_57._45 + 1) ) ; 
                __context__.SourceCodeLine = 22;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_57._45 == _57._46))  ) ) 
                    { 
                    __context__.SourceCodeLine = 22;
                    _57 . _47 = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 22;
                    _57 . _45 = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 22;
                _57 . _42 = (ushort) ( _51( __context__ , ref _57 ) ) ; 
                __context__.SourceCodeLine = 22;
                _57 . _43 = (ushort) ( _52( __context__ , ref _57 ) ) ; 
                } 
            
            __context__.SourceCodeLine = 22;
            return (ushort)( _58) ; 
            
            }
            
        private ushort _56 (  SplusExecutionContext __context__, _41 _58 ) 
            { 
            ushort _59 = 0;
            
            
            __context__.SourceCodeLine = 22;
            if ( Functions.TestForTrue  ( ( _48( __context__ , ref _58 ))  ) ) 
                { 
                __context__.SourceCodeLine = 22;
                _59 = (ushort) ( _58._46 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 22;
                _59 = (ushort) ( _58._44 ) ; 
                __context__.SourceCodeLine = 22;
                _58 . _44 = (ushort) ( (_58._44 + 1) ) ; 
                __context__.SourceCodeLine = 22;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_58._44 == _58._46))  ) ) 
                    { 
                    __context__.SourceCodeLine = 22;
                    _58 . _47 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 22;
                    _58 . _44 = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 22;
                _58 . _42 = (ushort) ( _51( __context__ , ref _58 ) ) ; 
                __context__.SourceCodeLine = 22;
                _58 . _43 = (ushort) ( _52( __context__ , ref _58 ) ) ; 
                } 
            
            __context__.SourceCodeLine = 22;
            return (ushort)( _59) ; 
            
            }
            
        private void _57 (  SplusExecutionContext __context__, ref _41 _59 ) 
            { 
            
            __context__.SourceCodeLine = 22;
            _59 . _44 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 22;
            _59 . _45 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 22;
            _59 . _42 = (ushort) ( _51( __context__ , ref _59 ) ) ; 
            __context__.SourceCodeLine = 22;
            _59 . _43 = (ushort) ( _52( __context__ , ref _59 ) ) ; 
            __context__.SourceCodeLine = 22;
            _59 . _47 = (ushort) ( 0 ) ; 
            
            }
            
        private void _58 (  SplusExecutionContext __context__, ref _41 _60 , ushort _61 ) 
            { 
            
            __context__.SourceCodeLine = 22;
            _57 (  __context__ ,   ref  _60 ) ; 
            __context__.SourceCodeLine = 22;
            _60 . _46 = (ushort) ( _61 ) ; 
            
            }
            
        private ushort _59 (  SplusExecutionContext __context__, ref _41 _61 , ushort _62 ) 
            { 
            ushort _63 = 0;
            ushort _64 = 0;
            ushort _65 = 0;
            
            
            __context__.SourceCodeLine = 23;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _62 >= _61._46 ))  ) ) 
                { 
                __context__.SourceCodeLine = 23;
                _63 = (ushort) ( _61._46 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 23;
                _63 = (ushort) ( (_62 + 1) ) ; 
                __context__.SourceCodeLine = 23;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_63 == _61._46))  ) ) 
                    { 
                    __context__.SourceCodeLine = 23;
                    _63 = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 23;
                _64 = (ushort) ( _51( __context__ , ref _61 ) ) ; 
                __context__.SourceCodeLine = 23;
                _65 = (ushort) ( _52( __context__ , ref _61 ) ) ; 
                __context__.SourceCodeLine = 23;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _64 < _65 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 23;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _63 <= _64 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _63 > _65 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 23;
                        _63 = (ushort) ( _61._46 ) ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 23;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_64 == _65))  ) ) 
                        { 
                        __context__.SourceCodeLine = 23;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (0 == _61._47))  ) ) 
                            { 
                            __context__.SourceCodeLine = 23;
                            _63 = (ushort) ( _61._46 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 23;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_63 == _65))  ) ) 
                                { 
                                __context__.SourceCodeLine = 23;
                                _63 = (ushort) ( _61._46 ) ; 
                                } 
                            
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 23;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _63 <= _64 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _63 > _65 ) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 23;
                            _63 = (ushort) ( _61._46 ) ; 
                            } 
                        
                        } 
                    
                    }
                
                } 
            
            __context__.SourceCodeLine = 23;
            return (ushort)( _63) ; 
            
            }
            
        private ushort _60 (  SplusExecutionContext __context__, ref _41 _62 ) 
            { 
            ushort _63 = 0;
            
            
            __context__.SourceCodeLine = 23;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_62._47 == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 23;
                _63 = (ushort) ( (_62._45 - _62._44) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 23;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_62._45 == _62._44))  ) ) 
                    { 
                    __context__.SourceCodeLine = 23;
                    _63 = (ushort) ( _62._46 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 23;
                    _63 = (ushort) ( ((_62._46 - _62._44) + _62._45) ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 24;
            return (ushort)( _63) ; 
            
            }
            
        private void _61 (  SplusExecutionContext __context__, ushort [] _63 , ushort [] _64 , ushort [] _65 ) 
            { 
            
            __context__.SourceCodeLine = 24;
            _63 [ 0] = (ushort) ( 254 ) ; 
            __context__.SourceCodeLine = 24;
            _63 [ 1] = (ushort) ( 126 ) ; 
            __context__.SourceCodeLine = 24;
            _63 [ 2] = (ushort) ( 62 ) ; 
            __context__.SourceCodeLine = 24;
            _63 [ 3] = (ushort) ( 30 ) ; 
            __context__.SourceCodeLine = 24;
            _63 [ 4] = (ushort) ( 14 ) ; 
            __context__.SourceCodeLine = 24;
            _63 [ 5] = (ushort) ( 6 ) ; 
            __context__.SourceCodeLine = 24;
            _63 [ 6] = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 24;
            _64 [ 0] = (ushort) ( 128 ) ; 
            __context__.SourceCodeLine = 24;
            _64 [ 1] = (ushort) ( 192 ) ; 
            __context__.SourceCodeLine = 24;
            _64 [ 2] = (ushort) ( 224 ) ; 
            __context__.SourceCodeLine = 24;
            _64 [ 3] = (ushort) ( 240 ) ; 
            __context__.SourceCodeLine = 24;
            _64 [ 4] = (ushort) ( 248 ) ; 
            __context__.SourceCodeLine = 24;
            _64 [ 5] = (ushort) ( 252 ) ; 
            __context__.SourceCodeLine = 24;
            _64 [ 6] = (ushort) ( 254 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 0] = (ushort) ( 9 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 1] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 2] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 3] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 4] = (ushort) ( 44 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 5] = (ushort) ( 3 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 6] = (ushort) ( 55 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 7] = (ushort) ( 18 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 8] = (ushort) ( 58 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 9] = (ushort) ( 33 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 10] = (ushort) ( 43 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 11] = (ushort) ( 24 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 12] = (ushort) ( 60 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 13] = (ushort) ( 51 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 14] = (ushort) ( 7 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 15] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 16] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 17] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 18] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 19] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _65 [ 20] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 21] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 22] = (ushort) ( 61 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 23] = (ushort) ( 48 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 24] = (ushort) ( 56 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 25] = (ushort) ( 46 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 26] = (ushort) ( 52 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 27] = (ushort) ( 38 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 28] = (ushort) ( 39 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 29] = (ushort) ( 36 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 30] = (ushort) ( 31 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 31] = (ushort) ( 59 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 32] = (ushort) ( 30 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 33] = (ushort) ( 20 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 34] = (ushort) ( 45 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 35] = (ushort) ( 37 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 36] = (ushort) ( 62 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 37] = (ushort) ( 14 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 38] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 39] = (ushort) ( 15 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 40] = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 41] = (ushort) ( 23 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 42] = (ushort) ( 5 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 43] = (ushort) ( 50 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 44] = (ushort) ( 13 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 45] = (ushort) ( 19 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 46] = (ushort) ( 10 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 47] = (ushort) ( 27 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 48] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 49] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 50] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 51] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 52] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 53] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 54] = (ushort) ( 28 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 55] = (ushort) ( 49 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 56] = (ushort) ( 63 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 57] = (ushort) ( 57 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 58] = (ushort) ( 22 ) ; 
            __context__.SourceCodeLine = 25;
            _65 [ 59] = (ushort) ( 40 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 60] = (ushort) ( 41 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 61] = (ushort) ( 12 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 62] = (ushort) ( 47 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 63] = (ushort) ( 34 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 64] = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 65] = (ushort) ( 16 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 66] = (ushort) ( 6 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 67] = (ushort) ( 11 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 68] = (ushort) ( 32 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 69] = (ushort) ( 21 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 70] = (ushort) ( 8 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 71] = (ushort) ( 4 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 72] = (ushort) ( 26 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 73] = (ushort) ( 29 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 74] = (ushort) ( 17 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 75] = (ushort) ( 42 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 76] = (ushort) ( 53 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 77] = (ushort) ( 54 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 78] = (ushort) ( 35 ) ; 
            __context__.SourceCodeLine = 26;
            _65 [ 79] = (ushort) ( 25 ) ; 
            
            }
            
        private void _62 (  SplusExecutionContext __context__, CrestronString _64 , ushort [] _65 , ushort _66 ) 
            { 
            CrestronString _67;
            _67  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
            
            ushort _68 = 0;
            ushort _69 = 0;
            
            
            __context__.SourceCodeLine = 26;
            _69 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 26;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_66; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _68  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_68  >= __FN_FORSTART_VAL__1) && (_68  <= __FN_FOREND_VAL__1) ) : ( (_68  <= __FN_FORSTART_VAL__1) && (_68  >= __FN_FOREND_VAL__1) ) ; _68  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 26;
                _67  .UpdateValue ( _67 + Functions.ItoHex (  (int) ( _65[ (_68 - 1) ] ) ) + " "  ) ; 
                __context__.SourceCodeLine = 26;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Mod( _68 , 16 ) == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (_68 == _66) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 26;
                    _67  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 26;
                    _69 = (ushort) ( (_69 + 1) ) ; 
                    } 
                
                __context__.SourceCodeLine = 26;
                } 
            
            
            }
            
        private uint _63 (  SplusExecutionContext __context__, uint [] _65 , ref ushort _66 ) 
            { 
            uint _67 = 0;
            uint _68 = 0;
            uint _69 = 0;
            uint _70 = 0;
            
            
            __context__.SourceCodeLine = 27;
            _67 = (uint) ( _65[ _66 ] ) ; 
            __context__.SourceCodeLine = 27;
            _68 = (uint) ( _65[ ((_66 + 13) & 15) ] ) ; 
            __context__.SourceCodeLine = 27;
            _69 = (uint) ( (((_67 ^ _68) ^ (_67 << 16)) ^ (_68 << 15)) ) ; 
            __context__.SourceCodeLine = 27;
            _68 = (uint) ( _65[ ((_66 + 9) & 15) ] ) ; 
            __context__.SourceCodeLine = 27;
            _68 = (uint) ( (_68 ^ (_68 >> 11)) ) ; 
            __context__.SourceCodeLine = 27;
            _65 [ _66] = (uint) ( (_69 ^ _68) ) ; 
            __context__.SourceCodeLine = 27;
            _67 = (uint) ( _65[ _66 ] ) ; 
            __context__.SourceCodeLine = 27;
            _70 = (uint) ( (_67 ^ ((_67 << 5) & 3661901088)) ) ; 
            __context__.SourceCodeLine = 27;
            _66 = (ushort) ( ((_66 + 15) & 15) ) ; 
            __context__.SourceCodeLine = 27;
            _67 = (uint) ( _65[ _66 ] ) ; 
            __context__.SourceCodeLine = 27;
            _65 [ _66] = (uint) ( (((((_67 ^ _69) ^ _70) ^ (_67 << 2)) ^ (_69 << 18)) ^ (_68 << 28)) ) ; 
            __context__.SourceCodeLine = 27;
            return (uint)( _65[ _66 ]) ; 
            
            }
            
        private void _64 (  SplusExecutionContext __context__, uint _66 , ref uint [] _67 , ref ushort _68 ) 
            { 
            ushort _69 = 0;
            
            uint _70 = 0;
            
            
            __context__.SourceCodeLine = 27;
            _70 = (uint) ( 0 ) ; 
            __context__.SourceCodeLine = 27;
            _68 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 27;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)15; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _69  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_69  >= __FN_FORSTART_VAL__1) && (_69  <= __FN_FOREND_VAL__1) ) : ( (_69  <= __FN_FORSTART_VAL__1) && (_69  >= __FN_FOREND_VAL__1) ) ; _69  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 27;
                _67 [ _69] = (uint) ( ((_66 + _70) ^ (1431655765 >> _69)) ) ; 
                __context__.SourceCodeLine = 27;
                _70 = (uint) ( (_70 + 7623293) ) ; 
                __context__.SourceCodeLine = 27;
                } 
            
            
            }
            
        private ushort _65 (  SplusExecutionContext __context__, CrestronString _67 , ushort _68 , ref ushort [] _69 , ref CrestronString [] _70 ) 
            { 
            ushort _71 = 0;
            
            ushort _72 = 0;
            
            ushort [] _73;
            _73  = new ushort[ 257 ];
            
            uint [] _74;
            _74  = new uint[ 257 ];
            
            uint _75 = 0;
            
            ushort _76 = 0;
            
            ushort [] _77;
            _77  = new ushort[ 4 ];
            
            short _78 = 0;
            short _79 = 0;
            
            ushort _80 = 0;
            ushort _81 = 0;
            
            ushort _82 = 0;
            
            uint _83 = 0;
            
            ushort _84 = 0;
            
            ushort _85 = 0;
            
            ushort [] _86;
            _86  = new ushort[ 7 ];
            
            ushort [] _87;
            _87  = new ushort[ 7 ];
            
            ushort [] _88;
            _88  = new ushort[ 80 ];
            
            uint [] _89;
            _89  = new uint[ 17 ];
            
            ushort _90 = 0;
            
            uint _91 = 0;
            
            
            __context__.SourceCodeLine = 28;
            _61 (  __context__ , (ushort[])( _86 ), (ushort[])( _87 ), (ushort[])( _88 )) ; 
            __context__.SourceCodeLine = 28;
            _72 = (ushort) ( Functions.Length( _67 ) ) ; 
            __context__.SourceCodeLine = 28;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _72 < 44 ) ) || Functions.TestForTrue ( Functions.BoolToInt (Mod( _72 , 4 ) != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( ((_72 * 3) / 4) > 256 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 28;
                _71 = (ushort) ( 0 ) ; 
                }
            
            else 
                { 
                __context__.SourceCodeLine = 28;
                _75 = (uint) ( 0 ) ; 
                __context__.SourceCodeLine = 28;
                _76 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 28;
                short __FN_FORSTART_VAL__1 = (short) ( 0 ) ;
                short __FN_FOREND_VAL__1 = (short)(_72 - 1); 
                int __FN_FORSTEP_VAL__1 = (int)4; 
                for ( _78  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_78  >= __FN_FORSTART_VAL__1) && (_78  <= __FN_FOREND_VAL__1) ) : ( (_78  <= __FN_FORSTART_VAL__1) && (_78  >= __FN_FOREND_VAL__1) ) ; _78  += (short)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 28;
                    short __FN_FORSTART_VAL__2 = (short) ( 0 ) ;
                    short __FN_FOREND_VAL__2 = (short)3; 
                    int __FN_FORSTEP_VAL__2 = (int)1; 
                    for ( _79  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_79  >= __FN_FORSTART_VAL__2) && (_79  <= __FN_FOREND_VAL__2) ) : ( (_79  <= __FN_FORSTART_VAL__2) && (_79  >= __FN_FOREND_VAL__2) ) ; _79  += (short)__FN_FORSTEP_VAL__2) 
                        { 
                        __context__.SourceCodeLine = 29;
                        _82 = (ushort) ( Byte( _67 , (int)( ((_78 + _79) + 1) ) ) ) ; 
                        __context__.SourceCodeLine = 29;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _82 >= 43 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _82 <= 122 ) )) ))  ) ) 
                            {
                            __context__.SourceCodeLine = 29;
                            _77 [ _79] = (ushort) ( _88[ (_82 - 43) ] ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 29;
                            _77 [ _79] = (ushort) ( 255 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 28;
                        } 
                    
                    __context__.SourceCodeLine = 29;
                    _73 [ _76] = (ushort) ( (((_77[ 0 ] << 2) | (_77[ 1 ] >> 4)) & 255) ) ; 
                    __context__.SourceCodeLine = 29;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_77[ 2 ] != 255))  ) ) 
                        { 
                        __context__.SourceCodeLine = 29;
                        _76 = (ushort) ( (_76 + 1) ) ; 
                        __context__.SourceCodeLine = 29;
                        _73 [ _76] = (ushort) ( (((_77[ 1 ] << 4) | (_77[ 2 ] >> 2)) & 255) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 29;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_77[ 3 ] != 255))  ) ) 
                        { 
                        __context__.SourceCodeLine = 29;
                        _76 = (ushort) ( (_76 + 1) ) ; 
                        __context__.SourceCodeLine = 29;
                        _73 [ _76] = (ushort) ( ((((_77[ 2 ] << 6) & 192) | _77[ 3 ]) & 255) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 29;
                    _76 = (ushort) ( (_76 + 1) ) ; 
                    __context__.SourceCodeLine = 28;
                    } 
                
                __context__.SourceCodeLine = 29;
                short __FN_FORSTART_VAL__3 = (short) ( 0 ) ;
                short __FN_FOREND_VAL__3 = (short)27; 
                int __FN_FORSTEP_VAL__3 = (int)1; 
                for ( _78  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (_78  >= __FN_FORSTART_VAL__3) && (_78  <= __FN_FOREND_VAL__3) ) : ( (_78  <= __FN_FORSTART_VAL__3) && (_78  >= __FN_FOREND_VAL__3) ) ; _78  += (short)__FN_FORSTEP_VAL__3) 
                    { 
                    __context__.SourceCodeLine = 29;
                    _80 = (ushort) ( Mod( _78 , 7 ) ) ; 
                    __context__.SourceCodeLine = 29;
                    _81 = (ushort) ( (_78 / 7) ) ; 
                    __context__.SourceCodeLine = 29;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((_73[ _78 ] & 1) != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 29;
                        _75 = (uint) ( (_75 | (1 << _78)) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 29;
                    _73 [ _78] = (ushort) ( ((((_73[ (_78 + _81) ] & _86[ _80 ]) << _80) | ((_73[ ((_78 + _81) + 1) ] & _87[ _80 ]) >> (7 - _80))) & 255) ) ; 
                    __context__.SourceCodeLine = 29;
                    } 
                
                __context__.SourceCodeLine = 29;
                short __FN_FORSTART_VAL__4 = (short) ( 28 ) ;
                short __FN_FOREND_VAL__4 = (short)31; 
                int __FN_FORSTEP_VAL__4 = (int)1; 
                for ( _78  = __FN_FORSTART_VAL__4; (__FN_FORSTEP_VAL__4 > 0)  ? ( (_78  >= __FN_FORSTART_VAL__4) && (_78  <= __FN_FOREND_VAL__4) ) : ( (_78  <= __FN_FORSTART_VAL__4) && (_78  >= __FN_FOREND_VAL__4) ) ; _78  += (short)__FN_FORSTEP_VAL__4) 
                    { 
                    __context__.SourceCodeLine = 29;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((_73[ _78 ] & 1) != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 29;
                        _75 = (uint) ( (_75 ^ (1 << _78)) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 29;
                    } 
                
                __context__.SourceCodeLine = 30;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _76 > 32 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 30;
                    short __FN_FORSTART_VAL__5 = (short) ( 32 ) ;
                    short __FN_FOREND_VAL__5 = (short)(_76 - 1); 
                    int __FN_FORSTEP_VAL__5 = (int)1; 
                    for ( _78  = __FN_FORSTART_VAL__5; (__FN_FORSTEP_VAL__5 > 0)  ? ( (_78  >= __FN_FORSTART_VAL__5) && (_78  <= __FN_FOREND_VAL__5) ) : ( (_78  <= __FN_FORSTART_VAL__5) && (_78  >= __FN_FOREND_VAL__5) ) ; _78  += (short)__FN_FORSTEP_VAL__5) 
                        { 
                        __context__.SourceCodeLine = 30;
                        _73 [ (_78 - 4)] = (ushort) ( _73[ _78 ] ) ; 
                        __context__.SourceCodeLine = 30;
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 30;
                _76 = (ushort) ( (_76 - 4) ) ; 
                __context__.SourceCodeLine = 30;
                _64 (  __context__ , (uint)( _75 ),   ref  _89 ,   ref  _90 ) ; 
                __context__.SourceCodeLine = 30;
                short __FN_FORSTART_VAL__6 = (short) ( 0 ) ;
                short __FN_FOREND_VAL__6 = (short)(_76 - 1); 
                int __FN_FORSTEP_VAL__6 = (int)1; 
                for ( _78  = __FN_FORSTART_VAL__6; (__FN_FORSTEP_VAL__6 > 0)  ? ( (_78  >= __FN_FORSTART_VAL__6) && (_78  <= __FN_FOREND_VAL__6) ) : ( (_78  <= __FN_FORSTART_VAL__6) && (_78  >= __FN_FOREND_VAL__6) ) ; _78  += (short)__FN_FORSTEP_VAL__6) 
                    { 
                    __context__.SourceCodeLine = 30;
                    _91 = (uint) ( (_76 - _78) ) ; 
                    __context__.SourceCodeLine = 30;
                    _74 [ _78] = (uint) ( (_63( __context__ , (uint[])( _89 ) , ref _90 ) >> 1) ) ; 
                    __context__.SourceCodeLine = 30;
                    _74 [ _78] = (uint) ( (Mod( _74[ _78 ] , _91 ) + _78) ) ; 
                    __context__.SourceCodeLine = 30;
                    _91 = (uint) ( _63( __context__ , (uint[])( _89 ) , ref _90 ) ) ; 
                    __context__.SourceCodeLine = 30;
                    _73 [ _78] = (ushort) ( (_73[ _78 ] ^ (_91 & 255)) ) ; 
                    __context__.SourceCodeLine = 30;
                    } 
                
                __context__.SourceCodeLine = 30;
                short __FN_FORSTART_VAL__7 = (short) ( (_76 - 1) ) ;
                short __FN_FOREND_VAL__7 = (short)0; 
                int __FN_FORSTEP_VAL__7 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( _78  = __FN_FORSTART_VAL__7; (__FN_FORSTEP_VAL__7 > 0)  ? ( (_78  >= __FN_FORSTART_VAL__7) && (_78  <= __FN_FOREND_VAL__7) ) : ( (_78  <= __FN_FORSTART_VAL__7) && (_78  >= __FN_FOREND_VAL__7) ) ; _78  += (short)__FN_FORSTEP_VAL__7) 
                    { 
                    __context__.SourceCodeLine = 30;
                    _83 = (uint) ( _74[ _78 ] ) ; 
                    __context__.SourceCodeLine = 30;
                    _84 = (ushort) ( _73[ _83 ] ) ; 
                    __context__.SourceCodeLine = 30;
                    _73 [ _83] = (ushort) ( _73[ _78 ] ) ; 
                    __context__.SourceCodeLine = 30;
                    _73 [ _78] = (ushort) ( _84 ) ; 
                    __context__.SourceCodeLine = 30;
                    } 
                
                __context__.SourceCodeLine = 30;
                _78 = (short) ( 0 ) ; 
                __context__.SourceCodeLine = 30;
                _71 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 30;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _78 < _76 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _71 < _68 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 30;
                    _85 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 30;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_78 + 3) <= _76 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 30;
                        _69 [ _71] = (ushort) ( ((_73[ _78 ] << 8) | _73[ (_78 + 1) ]) ) ; 
                        __context__.SourceCodeLine = 30;
                        _85 = (ushort) ( _73[ (_78 + 2) ] ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 30;
                    _78 = (short) ( (_78 + 3) ) ; 
                    __context__.SourceCodeLine = 30;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_78 + _85) > _76 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 30;
                        _71 = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 30;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 30;
                    _70 [ _71]  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 30;
                    short __FN_FORSTART_VAL__8 = (short) ( 0 ) ;
                    short __FN_FOREND_VAL__8 = (short)(_85 - 1); 
                    int __FN_FORSTEP_VAL__8 = (int)1; 
                    for ( _79  = __FN_FORSTART_VAL__8; (__FN_FORSTEP_VAL__8 > 0)  ? ( (_79  >= __FN_FORSTART_VAL__8) && (_79  <= __FN_FOREND_VAL__8) ) : ( (_79  <= __FN_FORSTART_VAL__8) && (_79  >= __FN_FOREND_VAL__8) ) ; _79  += (short)__FN_FORSTEP_VAL__8) 
                        { 
                        __context__.SourceCodeLine = 31;
                        _70 [ _71]  .UpdateValue ( _70 [ _71] + Functions.Chr (  (int) ( _73[ (_78 + _79) ] ) )  ) ; 
                        __context__.SourceCodeLine = 30;
                        } 
                    
                    __context__.SourceCodeLine = 31;
                    _71 = (ushort) ( (_71 + 1) ) ; 
                    __context__.SourceCodeLine = 31;
                    _78 = (short) ( (_78 + _85) ) ; 
                    __context__.SourceCodeLine = 30;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 31;
            return (ushort)( _71) ; 
            
            }
            
        private CrestronString _66 (  SplusExecutionContext __context__, CrestronString _68 ) 
            { 
            CrestronString _69;
            CrestronString _70;
            _69  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            _70  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            ushort _71 = 0;
            ushort _72 = 0;
            
            
            __context__.SourceCodeLine = 31;
            _70  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 31;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( _68 ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _71  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_71  >= __FN_FORSTART_VAL__1) && (_71  <= __FN_FOREND_VAL__1) ) : ( (_71  <= __FN_FORSTART_VAL__1) && (_71  >= __FN_FOREND_VAL__1) ) ; _71  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 31;
                _71 = (ushort) ( Functions.Find( ":" , _68 ) ) ; 
                __context__.SourceCodeLine = 31;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _71 > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 31;
                    _69  .UpdateValue ( Functions.Remove ( ":" , _68 )  ) ; 
                    __context__.SourceCodeLine = 31;
                    _69  .UpdateValue ( Functions.Left ( _69 ,  (int) ( (Functions.Length( _69 ) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 31;
                    _70  .UpdateValue ( _70 + _69  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 31;
                    _70  .UpdateValue ( _70 + _68  ) ; 
                    __context__.SourceCodeLine = 31;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 31;
                } 
            
            __context__.SourceCodeLine = 31;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _70 , (int)( 1 ) ) == " "))  ) ) 
                {
                __context__.SourceCodeLine = 31;
                _70  .UpdateValue ( Functions.Right ( _70 ,  (int) ( (Functions.Length( _70 ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 31;
                }
            
            __context__.SourceCodeLine = 31;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Right( _70 , (int)( 1 ) ) == " "))  ) ) 
                {
                __context__.SourceCodeLine = 31;
                _70  .UpdateValue ( Functions.Left ( _70 ,  (int) ( (Functions.Length( _70 ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 31;
                }
            
            __context__.SourceCodeLine = 31;
            return ( Functions.Lower ( _70 ) ) ; 
            
            }
            
        private ushort _67 (  SplusExecutionContext __context__, CrestronString _69 , CrestronString _70 , CrestronString _71 , ushort _72 ) 
            { 
            ushort _73 = 0;
            ushort _74 = 0;
            ushort _75 = 0;
            
            CrestronString _76;
            CrestronString _77;
            _76  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            _77  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            ushort [] _78;
            _78  = new ushort[ 17 ];
            
            CrestronString [] _79;
            _79  = new CrestronString[ 17 ];
            for( uint i = 0; i < 17; i++ )
                _79 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            CrestronString _80;
            _80  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            
            CrestronString _81;
            _81  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            ushort _82 = 0;
            
            
            __context__.SourceCodeLine = 32;
            _82 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 32;
            _73 = (ushort) ( 16 ) ; 
            __context__.SourceCodeLine = 32;
            while ( Functions.TestForTrue  ( ( Functions.Find( "License Activation is :" , _71 ))  ) ) 
                { 
                __context__.SourceCodeLine = 32;
                _80  .UpdateValue ( Functions.Remove ( "License Activation is :" , _71 )  ) ; 
                __context__.SourceCodeLine = 32;
                } 
            
            __context__.SourceCodeLine = 32;
            _71  .UpdateValue ( Functions.Remove ( "\u000D" , _71 )  ) ; 
            __context__.SourceCodeLine = 32;
            _81  .UpdateValue ( Functions.Left ( _71 ,  (int) ( (Functions.Length( _71 ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 32;
            _74 = (ushort) ( _65( __context__ , _69 , (ushort)( _73 ) , ref _78 , ref _79 ) ) ; 
            __context__.SourceCodeLine = 32;
            Print( "JanusLicenceDecoder_checkLicense   result  {0:d}\r\n", (short)_74) ; 
            __context__.SourceCodeLine = 32;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_74; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _75  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_75  >= __FN_FORSTART_VAL__1) && (_75  <= __FN_FOREND_VAL__1) ) : ( (_75  <= __FN_FORSTART_VAL__1) && (_75  >= __FN_FOREND_VAL__1) ) ; _75  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 32;
                Print( "key[{0:d}]  {1}\r\n", (short)_78[ _75 ], _79 [ _75 ] ) ; 
                __context__.SourceCodeLine = 32;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_78[ _75 ] == 6) ) || Functions.TestForTrue ( Functions.BoolToInt (_78[ _75 ] == 2) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 32;
                    _76  .UpdateValue ( _66 (  __context__ , _79[ _75 ])  ) ; 
                    __context__.SourceCodeLine = 32;
                    _77  .UpdateValue ( _66 (  __context__ , _81)  ) ; 
                    __context__.SourceCodeLine = 32;
                    Print( "licenceValueClean  {0}\r\n", _76 ) ; 
                    __context__.SourceCodeLine = 33;
                    Print( "switchValueClean  {0}\r\n", _77 ) ; 
                    __context__.SourceCodeLine = 33;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_77 == _76))  ) ) 
                        { 
                        __context__.SourceCodeLine = 33;
                        _82 = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 33;
                        _82 = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 33;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_78[ _75 ] == 4))  ) ) 
                        { 
                        __context__.SourceCodeLine = 33;
                        Print( "licenceType  {0}\r\n", _79 [ _75 ] ) ; 
                        __context__.SourceCodeLine = 33;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_70 == _79[ _75 ]))  ) ) 
                            { 
                            __context__.SourceCodeLine = 33;
                            _82 = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 33;
                            _82 = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 32;
                } 
            
            __context__.SourceCodeLine = 33;
            return (ushort)( _82) ; 
            
            }
            
        private uint _68 (  SplusExecutionContext __context__ ) 
            { 
            uint _70 = 0;
            
            
            __context__.SourceCodeLine = 33;
            _70 = (uint) ( ((((Functions.GetMinutesNum() + (Functions.GetHourNum() * 60)) + ((Functions.GetDateNum() * 24) * 60)) + (((Functions.GetMonthNum() * 31) * 24) * 60)) + ((((Functions.GetYearNum() * 12) * 31) * 24) * 60)) ) ; 
            __context__.SourceCodeLine = 33;
            return (uint)( _70) ; 
            
            }
            
        private uint _69 (  SplusExecutionContext __context__, uint _71 ) 
            { 
            uint _72 = 0;
            uint _73 = 0;
            
            
            __context__.SourceCodeLine = 33;
            _72 = (uint) ( (_68( __context__ ) - _71) ) ; 
            __context__.SourceCodeLine = 33;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _72 > 30 ))  ) ) 
                {
                __context__.SourceCodeLine = 33;
                _73 = (uint) ( 0 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 33;
                _73 = (uint) ( (30 - _72) ) ; 
                }
            
            __context__.SourceCodeLine = 33;
            return (uint)( _73) ; 
            
            }
            
        private CrestronString _70 (  SplusExecutionContext __context__, ushort _72 , ushort _73 ) 
            { 
            CrestronString _74;
            _74  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 34;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_72 == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 34;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_73 == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 34;
                    _74  .UpdateValue ( "Invalid licence / Demo Expired"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 34;
                    MakeString ( _74 , "Demo mode ({0:d} seconds remaining)", (short)_73) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 34;
                _74  .UpdateValue ( "Licence OK"  ) ; 
                } 
            
            __context__.SourceCodeLine = 34;
            return ( _74 ) ; 
            
            }
            
        Crestron.Logos.SplusObjects.DigitalInput __TRIGGER_SEND_NEXT_CMD;
        Crestron.Logos.SplusObjects.DigitalInput __TRIGGER_HEARTBEAT;
        Crestron.Logos.SplusObjects.DigitalInput __TRIGGER_PROCESS_SOCKET_RECEIVE;
        Crestron.Logos.SplusObjects.DigitalInput REFRESH_STATUS;
        Crestron.Logos.SplusObjects.DigitalInput START_MODULE;
        Crestron.Logos.SplusObjects.DigitalInput SEND_SAVE;
        Crestron.Logos.SplusObjects.StringInput FAVOUTITE_CMD;
        Crestron.Logos.SplusObjects.StringInput POE_CMD;
        Crestron.Logos.SplusObjects.StringInput DEBUGENABLE;
        Crestron.Logos.SplusObjects.StringInput CRESTRON_MAC;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> OUTPUT;
        Crestron.Logos.SplusObjects.DigitalOutput __TRIGGER_SEND_NEXT_CMD_OUT;
        Crestron.Logos.SplusObjects.DigitalOutput __TRIGGER_START_HEARTBEAT_OUT;
        Crestron.Logos.SplusObjects.DigitalOutput __SOCKET_RECEIVE_BUSY;
        Crestron.Logos.SplusObjects.DigitalOutput REBOOTINGINPROGRESS;
        Crestron.Logos.SplusObjects.StringOutput OPERATIONFB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CRESTRONID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput VERSION__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ERRORMSG__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput NUMOFOUTPUTS;
        Crestron.Logos.SplusObjects.AnalogOutput NUMOFINPUTS;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> OUTPUTFB;
        SplusTcpClient SWITCH_CLIENT;
        StringParameter P_SWITCHIP;
        StringParameter P_SWITCHPORT;
        StringParameter P_SWITCHUSERNAME;
        StringParameter P_SWITCHPASSWORD;
        StringParameter P_SWITCHLICENCEKEY;
        _71 _79;
        _80 _86;
        _87 [] _94;
        _87 _95;
        _41 _96;
        ushort _97 = 0;
        ushort _98 = 0;
        ushort _99 = 0;
        ushort _100 = 0;
        ushort _101 = 0;
        CrestronString _102;
        ushort [] _103;
        CrestronString _104;
        ushort _105 = 0;
        ushort _106 = 0;
        CrestronString _107;
        CrestronString [] _108;
        CrestronString [] _109;
        ushort [,] _110;
        ushort _111 = 0;
        ushort _112 = 0;
        ushort _113 = 0;
        ushort _114 = 0;
        CrestronString [] _115;
        CrestronString [] _116;
        ushort _117 = 0;
        ushort _118 = 0;
        ushort _119 = 0;
        ushort _120 = 0;
        ushort _121 = 0;
        ushort _122 = 0;
        ushort _123 = 0;
        private void _124 (  SplusExecutionContext __context__, CrestronString _126 , CrestronString _127 ) 
            { 
            
            __context__.SourceCodeLine = 37;
            if ( Functions.TestForTrue  ( ( _101)  ) ) 
                {
                __context__.SourceCodeLine = 37;
                Print( "\r\n {0}: {1} \r\n", _126 , _127 ) ; 
                }
            
            
            }
            
        private CrestronString _125 (  SplusExecutionContext __context__, CrestronString _127 , ushort _3 , ushort _4 ) 
            { 
            ushort _128 = 0;
            
            CrestronString _129;
            _129  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 254, this );
            
            
            __context__.SourceCodeLine = 38;
            _128 = (ushort) ( (_4 - _3) ) ; 
            __context__.SourceCodeLine = 38;
            _129  .UpdateValue ( Functions.Mid ( _127 ,  (int) ( _3 ) ,  (int) ( _128 ) )  ) ; 
            __context__.SourceCodeLine = 38;
            return ( _129 ) ; 
            
            }
            
        private void _126 (  SplusExecutionContext __context__, ushort _77 ) 
            { 
            CrestronString _128;
            _128  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            ushort _129 = 0;
            
            
            __context__.SourceCodeLine = 38;
            _129 = (ushort) ( Functions.BoolToInt (_79._77 != _77) ) ; 
            __context__.SourceCodeLine = 38;
            _79 . _77 = (ushort) ( _77 ) ; 
            __context__.SourceCodeLine = 38;
            
                {
                int __SPLS_TMPVAR__SWTCH_6__ = ((int)_77);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 0) ) ) ) 
                        {
                        __context__.SourceCodeLine = 38;
                        _128  .UpdateValue ( "Not connected"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 38;
                        _128  .UpdateValue ( "Connecting"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 38;
                        _128  .UpdateValue ( "Logging in"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 38;
                        _128  .UpdateValue ( "Invalid username or password"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 38;
                        _128  .UpdateValue ( "Invalid privileged password"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 6) ) ) ) 
                        {
                        __context__.SourceCodeLine = 38;
                        _128  .UpdateValue ( "Configuring"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 38;
                        _128  .UpdateValue ( _79 . _78 + Functions.ItoA (  (int) ( _86._83 ) ) + " x " + Functions.ItoA (  (int) ( _86._84 ) )  ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 38;
                        _128  .UpdateValue ( "Unknown"  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 38;
            OPERATIONFB__DOLLAR__  .UpdateValue ( _128  ) ; 
            
            }
            
        private void _127 (  SplusExecutionContext __context__, _87 _129 ) 
            { 
            ushort _130 = 0;
            
            CrestronString _131;
            _131  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            
            __context__.SourceCodeLine = 39;
            _130 = (ushort) ( _55( __context__ , ref _96 ) ) ; 
            __context__.SourceCodeLine = 39;
            MakeString ( _131 , "enqueue iAddIndex={0:d} cmd={1}", (short)_130, _129 . _88 ) ; 
            __context__.SourceCodeLine = 39;
            _124 (  __context__ , "MsgQueue", _131) ; 
            __context__.SourceCodeLine = 39;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_130 != _96._46))  ) ) 
                { 
                __context__.SourceCodeLine = 39;
                _94 [ _130] . _88  .UpdateValue ( _129 . _88  ) ; 
                __context__.SourceCodeLine = 39;
                _94 [ _130] . _89  .UpdateValue ( _129 . _89  ) ; 
                __context__.SourceCodeLine = 39;
                _94 [ _130] . _90 = (ushort) ( _129._90 ) ; 
                __context__.SourceCodeLine = 39;
                _94 [ _130] . _91  .UpdateValue ( _129 . _91  ) ; 
                __context__.SourceCodeLine = 39;
                _94 [ _130] . _92 = (ushort) ( _129._92 ) ; 
                } 
            
            
            }
            
        private void _128 (  SplusExecutionContext __context__, ushort _130 , _87 _131 ) 
            { 
            
            __context__.SourceCodeLine = 39;
            _131 . _88  .UpdateValue ( _94 [ _130] . _88  ) ; 
            __context__.SourceCodeLine = 39;
            _131 . _89  .UpdateValue ( _94 [ _130] . _89  ) ; 
            __context__.SourceCodeLine = 39;
            _131 . _90 = (ushort) ( _94[ _130 ]._90 ) ; 
            __context__.SourceCodeLine = 39;
            _131 . _91  .UpdateValue ( _94 [ _130] . _91  ) ; 
            __context__.SourceCodeLine = 39;
            _131 . _92 = (ushort) ( _94[ _130 ]._92 ) ; 
            
            }
            
        private void _129 (  SplusExecutionContext __context__, ref _87 _131 ) 
            { 
            ushort _132 = 0;
            
            
            __context__.SourceCodeLine = 39;
            _132 = (ushort) ( _56( __context__ , _96 ) ) ; 
            __context__.SourceCodeLine = 39;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _132 < _96._46 ))  ) ) 
                { 
                __context__.SourceCodeLine = 39;
                _128 (  __context__ , (ushort)( _132 ), _131) ; 
                __context__.SourceCodeLine = 40;
                _94 [ _132] . _88  .UpdateValue ( "NULL STRING"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 40;
                _124 (  __context__ , "Queue", "Queue:Error") ; 
                } 
            
            
            }
            
        private ushort _130 (  SplusExecutionContext __context__, CrestronString _132 ) 
            { 
            ushort _133 = 0;
            ushort _134 = 0;
            ushort _135 = 0;
            
            
            __context__.SourceCodeLine = 40;
            _135 = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 40;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( _132 ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _133  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_133  >= __FN_FORSTART_VAL__1) && (_133  <= __FN_FOREND_VAL__1) ) : ( (_133  <= __FN_FORSTART_VAL__1) && (_133  >= __FN_FOREND_VAL__1) ) ; _133  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 40;
                _134 = (ushort) ( Byte( _132 , (int)( _133 ) ) ) ; 
                __context__.SourceCodeLine = 40;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _134 >= 48 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _134 <= 57 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_134 == 46) )) ))  ) ) 
                    { 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 40;
                    _135 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 40;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 40;
                } 
            
            __context__.SourceCodeLine = 40;
            return (ushort)( _135) ; 
            
            }
            
        private ushort _131 (  SplusExecutionContext __context__, CrestronString _133 ) 
            { 
            ushort [] _134;
            _134  = new ushort[ 4 ];
            
            ushort [] _135;
            _135  = new ushort[ 5 ];
            
            CrestronString _136;
            _136  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            
            
            __context__.SourceCodeLine = 40;
            _134 [ 1] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 40;
            _134 [ 2] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 40;
            _134 [ 3] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 40;
            _135 [ 1] = (ushort) ( 256 ) ; 
            __context__.SourceCodeLine = 40;
            _135 [ 2] = (ushort) ( 256 ) ; 
            __context__.SourceCodeLine = 40;
            _135 [ 3] = (ushort) ( 256 ) ; 
            __context__.SourceCodeLine = 40;
            _135 [ 4] = (ushort) ( 256 ) ; 
            __context__.SourceCodeLine = 40;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _133 ) <= 15 ) ) && Functions.TestForTrue ( _130( __context__ , _133 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 40;
                _134 [ 1] = (ushort) ( Functions.Find( "." , _133 , 1 ) ) ; 
                __context__.SourceCodeLine = 40;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _134[ 1 ] > 1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 41;
                    _135 [ 1] = (ushort) ( Functions.Atoi( Functions.Left( _133 , (int)( (_134[ 1 ] - 1) ) ) ) ) ; 
                    __context__.SourceCodeLine = 41;
                    _134 [ 2] = (ushort) ( Functions.Find( "." , _133 , (_134[ 1 ] + 1) ) ) ; 
                    __context__.SourceCodeLine = 41;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_134[ 2 ] + 1) > _134[ 1 ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 41;
                        _135 [ 2] = (ushort) ( Functions.Atoi( Functions.Mid( _133 , (int)( (_134[ 1 ] + 1) ) , (int)( ((_134[ 2 ] - _134[ 1 ]) - 1) ) ) ) ) ; 
                        __context__.SourceCodeLine = 41;
                        _134 [ 3] = (ushort) ( Functions.Find( "." , _133 , (_134[ 2 ] + 1) ) ) ; 
                        __context__.SourceCodeLine = 41;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_134[ 3 ] + 1) > _134[ 2 ] ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 41;
                            _135 [ 3] = (ushort) ( Functions.Atoi( Functions.Mid( _133 , (int)( (_134[ 2 ] + 1) ) , (int)( ((_134[ 3 ] - _134[ 2 ]) - 1) ) ) ) ) ; 
                            __context__.SourceCodeLine = 41;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _133 ) > _134[ 3 ] ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _133 ) < (_134[ 3 ] + 4) ) )) ))  ) ) 
                                {
                                __context__.SourceCodeLine = 41;
                                _135 [ 4] = (ushort) ( Functions.Atoi( Functions.Right( _133 , (int)( (Functions.Length( _133 ) - _134[ 3 ]) ) ) ) ) ; 
                                }
                            
                            } 
                        
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 41;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _135[ 1 ] < 256 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _135[ 2 ] < 256 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _135[ 3 ] < 256 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _135[ 4 ] < 256 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 41;
                return (ushort)( 65535) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 41;
                return (ushort)( 0) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private void _132 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 41;
            _79 . _72  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 41;
            _79 . _73 = (ushort) ( 0 ) ; 
            
            }
            
        private void _133 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 42;
            _124 (  __context__ , "MessageHandler g_MessageHandlerComms.connectState", Functions.ItoA( (int)( _79._77 ) )) ; 
            __context__.SourceCodeLine = 42;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _79._77 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 42;
                _57 (  __context__ ,   ref  _96 ) ; 
                __context__.SourceCodeLine = 42;
                Functions.SocketDisconnectClient ( SWITCH_CLIENT ) ; 
                __context__.SourceCodeLine = 42;
                _126 (  __context__ , (ushort)( 0 )) ; 
                } 
            
            
            }
            
        private void _134 (  SplusExecutionContext __context__ ) 
            { 
            CrestronString _136;
            _136  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            
            short _137 = 0;
            short _138 = 0;
            
            
            __context__.SourceCodeLine = 42;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_79._77 == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 42;
                _95 . _88  .UpdateValue ( "NULL STRING"  ) ; 
                __context__.SourceCodeLine = 42;
                _95 . _89  .UpdateValue ( "NULL STRING"  ) ; 
                __context__.SourceCodeLine = 42;
                _95 . _90 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 42;
                _95 . _91  .UpdateValue ( "NULL STRING"  ) ; 
                __context__.SourceCodeLine = 42;
                _95 . _92 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 42;
                _126 (  __context__ , (ushort)( 1 )) ; 
                __context__.SourceCodeLine = 42;
                _79 . _72  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 42;
                _79 . _73 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 42;
                if ( Functions.TestForTrue  ( ( _131( __context__ , P_SWITCHIP  ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 42;
                    _124 (  __context__ , "MessageHandler", "SocketConnectClient") ; 
                    __context__.SourceCodeLine = 42;
                    _137 = (short) ( Functions.SocketConnectClient( SWITCH_CLIENT , P_SWITCHIP  , (ushort)( Functions.Atoi( P_SWITCHPORT  ) ) , (ushort)( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 43;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_137 == -7) ) || Functions.TestForTrue ( Functions.BoolToInt (_137 == -8) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 43;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_137 == -7))  ) ) 
                            {
                            __context__.SourceCodeLine = 43;
                            _124 (  __context__ , "MessageHandler", "Switch - Connected") ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 43;
                            _124 (  __context__ , "MessageHandler", "Switch - Connection attempt in progress") ; 
                            }
                        
                        __context__.SourceCodeLine = 43;
                        return ; 
                        } 
                    
                    __context__.SourceCodeLine = 43;
                    Functions.Delay (  (int) ( 1000 ) ) ; 
                    __context__.SourceCodeLine = 43;
                    _138 = (short) ( Functions.SocketGetAddressAsRequested( SWITCH_CLIENT , ref _136 ) ) ; 
                    __context__.SourceCodeLine = 43;
                    _104  .UpdateValue ( "Switch - Attempting to Connect to device at " + P_SWITCHIP + ":" + P_SWITCHPORT  ) ; 
                    __context__.SourceCodeLine = 43;
                    _124 (  __context__ , "MessageHandler", _104) ; 
                    __context__.SourceCodeLine = 43;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_137 != 0) ) || Functions.TestForTrue ( Functions.BoolToInt (_138 != 0) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 43;
                        _104  .UpdateValue ( "Switch - IP Client Connect Error: " + Functions.ItoA (  (int) ( _137 ) ) + " , " + Functions.ItoA (  (int) ( _138 ) ) + " Address: " + _136  ) ; 
                        __context__.SourceCodeLine = 44;
                        _124 (  __context__ , "MessageHandler", _104) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 44;
                    _104  .UpdateValue ( "Switch - Stored IP Address is Invalid: " + P_SWITCHIP  ) ; 
                    __context__.SourceCodeLine = 44;
                    _124 (  __context__ , "MessageHandler", _104) ; 
                    } 
                
                } 
            
            
            }
            
        private void _135 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 44;
            _124 (  __context__ , "MessageHandler", "queueTimeOut") ; 
            __context__.SourceCodeLine = 44;
            _133 (  __context__  ) ; 
            __context__.SourceCodeLine = 44;
            _134 (  __context__  ) ; 
            
            }
            
        private void _136 (  SplusExecutionContext __context__, CrestronString _138 ) 
            { 
            CrestronString _139;
            _139  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
            
            ushort _140 = 0;
            
            
            __context__.SourceCodeLine = 44;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_138 != "NULL STRING"))  ) ) 
                { 
                __context__.SourceCodeLine = 44;
                _140 = (ushort) ( Functions.Find( "#NULL#" , _138 ) ) ; 
                __context__.SourceCodeLine = 44;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _140 > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 44;
                    _139  .UpdateValue ( Functions.Left ( _138 ,  (int) ( (_140 - 1) ) )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 44;
                    _139  .UpdateValue ( _138 + "\r\n"  ) ; 
                    } 
                
                __context__.SourceCodeLine = 44;
                _124 (  __context__ , "fnMessageHandler_sendLuxulCommand command ", _139) ; 
                __context__.SourceCodeLine = 44;
                Functions.SocketSend ( SWITCH_CLIENT , _139 ) ; 
                } 
            
            
            }
            
        private void _137 (  SplusExecutionContext __context__, _87 _139 ) 
            { 
            
            __context__.SourceCodeLine = 44;
            _95 . _88  .UpdateValue ( _139 . _88  ) ; 
            __context__.SourceCodeLine = 44;
            _95 . _89  .UpdateValue ( _139 . _89  ) ; 
            __context__.SourceCodeLine = 45;
            _95 . _90 = (ushort) ( _139._90 ) ; 
            __context__.SourceCodeLine = 45;
            _95 . _91  .UpdateValue ( _139 . _91  ) ; 
            __context__.SourceCodeLine = 45;
            _95 . _92 = (ushort) ( _139._92 ) ; 
            __context__.SourceCodeLine = 45;
            _100 = (ushort) ( (_100 + 1) ) ; 
            __context__.SourceCodeLine = 45;
            _122 = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 45;
            CreateWait ( "WAIT_FOR_RX_SEND" , 10000 , WAIT_FOR_RX_SEND_Callback ) ;
            __context__.SourceCodeLine = 45;
            _136 (  __context__ , _95._88) ; 
            
            }
            
        public void WAIT_FOR_RX_SEND_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 45;
            _135 (  __context__  ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    private void _138 (  SplusExecutionContext __context__, CrestronString _140 ) 
        { 
        
        __context__.SourceCodeLine = 45;
        _126 (  __context__ , (ushort)( 3 )) ; 
        
        }
        
    private void _139 (  SplusExecutionContext __context__, CrestronString _141 ) 
        { 
        _87 _142;
        _142  = new _87( this, true );
        _142 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 45;
        _124 (  __context__ , "MessageHandler_sendPassword", "MessageHandler_sendPassword") ; 
        __context__.SourceCodeLine = 45;
        _142 . _88  .UpdateValue ( P_SWITCHPASSWORD  ) ; 
        __context__.SourceCodeLine = 45;
        _142 . _89  .UpdateValue ( "#"  ) ; 
        __context__.SourceCodeLine = 45;
        _142 . _90 = (ushort) ( 14 ) ; 
        __context__.SourceCodeLine = 45;
        _142 . _91  .UpdateValue ( "Username:"  ) ; 
        __context__.SourceCodeLine = 45;
        _142 . _92 = (ushort) ( 14 ) ; 
        __context__.SourceCodeLine = 45;
        _137 (  __context__ , _142) ; 
        
        }
        
    private void _140 (  SplusExecutionContext __context__, CrestronString _142 ) 
        { 
        _87 _143;
        _143  = new _87( this, true );
        _143 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 45;
        _124 (  __context__ , "MessageHandler_sendUsername", "MessageHandler_sendUsername") ; 
        __context__.SourceCodeLine = 45;
        _143 . _88  .UpdateValue ( P_SWITCHUSERNAME  ) ; 
        __context__.SourceCodeLine = 45;
        _143 . _89  .UpdateValue ( "Password:"  ) ; 
        __context__.SourceCodeLine = 46;
        _143 . _90 = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 46;
        _143 . _91  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 46;
        _143 . _92 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 46;
        _137 (  __context__ , _143) ; 
        
        }
        
    private void _141 (  SplusExecutionContext __context__ ) 
        { 
        _87 _143;
        _143  = new _87( this, true );
        _143 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 46;
        _124 (  __context__ , "MessageHandler_beginLoginSequence", "MessageHandler_beginLoginSequence") ; 
        __context__.SourceCodeLine = 46;
        _143 . _88  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 46;
        _143 . _89  .UpdateValue ( "Username:"  ) ; 
        __context__.SourceCodeLine = 46;
        _143 . _90 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 46;
        _143 . _91  .UpdateValue ( "#"  ) ; 
        __context__.SourceCodeLine = 46;
        _143 . _92 = (ushort) ( 14 ) ; 
        
        }
        
    private void _142 (  SplusExecutionContext __context__, ushort _144 ) 
        { 
        CrestronString _145;
        _145  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
        
        
        __context__.SourceCodeLine = 46;
        _145  .UpdateValue ( "Connection Status Changed. IsConnected = " + Functions.ItoA (  (int) ( _144 ) )  ) ; 
        __context__.SourceCodeLine = 46;
        _124 (  __context__ , "MessageHandler", _145) ; 
        __context__.SourceCodeLine = 46;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _144 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 46;
            _126 (  __context__ , (ushort)( 2 )) ; 
            __context__.SourceCodeLine = 46;
            _141 (  __context__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 46;
            _126 (  __context__ , (ushort)( 0 )) ; 
            __context__.SourceCodeLine = 46;
            _57 (  __context__ ,   ref  _96 ) ; 
            } 
        
        
        }
        
    private void _143 (  SplusExecutionContext __context__, CrestronString _145 , ushort _146 , CrestronString _147 , ushort _148 , CrestronString _149 ) 
        { 
        ushort _150 = 0;
        
        _87 _151;
        _151  = new _87( this, true );
        _151 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 47;
        _151 . _88  .UpdateValue ( _145  ) ; 
        __context__.SourceCodeLine = 47;
        _151 . _89  .UpdateValue ( _147  ) ; 
        __context__.SourceCodeLine = 47;
        _151 . _90 = (ushort) ( _146 ) ; 
        __context__.SourceCodeLine = 47;
        _151 . _91  .UpdateValue ( _149  ) ; 
        __context__.SourceCodeLine = 47;
        _151 . _92 = (ushort) ( _146 ) ; 
        __context__.SourceCodeLine = 47;
        _124 (  __context__ , "MessageHandler_sendMessage", _145) ; 
        __context__.SourceCodeLine = 47;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _79._77 >= 5 ) ) && Functions.TestForTrue ( Functions.BoolToInt (_95._88 == "NULL STRING") )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 47;
            _137 (  __context__ , _151) ; 
            __context__.SourceCodeLine = 47;
            _124 (  __context__ , "MessageHandler_sendMessage", "MessageHandler_sendNow") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 47;
            _127 (  __context__ , _151) ; 
            __context__.SourceCodeLine = 47;
            _134 (  __context__  ) ; 
            } 
        
        
        }
        
    private void _144 (  SplusExecutionContext __context__, CrestronString _146 , ushort _147 , CrestronString _148 , ushort _149 , CrestronString _150 ) 
        { 
        ushort _151 = 0;
        
        _87 _152;
        _152  = new _87( this, true );
        _152 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 47;
        _152 . _88  .UpdateValue ( _146  ) ; 
        __context__.SourceCodeLine = 47;
        _152 . _89  .UpdateValue ( _148  ) ; 
        __context__.SourceCodeLine = 47;
        _152 . _90 = (ushort) ( _147 ) ; 
        __context__.SourceCodeLine = 47;
        _152 . _91  .UpdateValue ( _150  ) ; 
        __context__.SourceCodeLine = 47;
        _152 . _92 = (ushort) ( _147 ) ; 
        __context__.SourceCodeLine = 47;
        _127 (  __context__ , _152) ; 
        
        }
        
    private void _145 (  SplusExecutionContext __context__ ) 
        { 
        _87 _147;
        _147  = new _87( this, true );
        _147 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 47;
        _129 (  __context__ ,   ref  _147 ) ; 
        __context__.SourceCodeLine = 47;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_147._88 == "NULL STRING"))  ) ) 
            { 
            __context__.SourceCodeLine = 47;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_1__" , 10 , __SPLS_TMPVAR__WAITLABEL_1___Callback ) ;
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 48;
            _137 (  __context__ , _147) ; 
            } 
        
        
        }
        
    public void __SPLS_TMPVAR__WAITLABEL_1___CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            
            __context__.SourceCodeLine = 48;
            _124 (  __context__ , "Wait 10 - NULL_MESSAGE", "") ; 
            __context__.SourceCodeLine = 48;
            _145 (  __context__  ) ; 
            
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    
private void _146 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 48;
    _124 (  __context__ , "MessageHandler", "Closing TCP connection comms") ; 
    __context__.SourceCodeLine = 48;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_79._75 != ""))  ) ) 
        { 
        __context__.SourceCodeLine = 48;
        _79 . _75  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 48;
        _79 . _76  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 48;
        _57 (  __context__ ,   ref  _96 ) ; 
        __context__.SourceCodeLine = 48;
        _133 (  __context__  ) ; 
        __context__.SourceCodeLine = 48;
        _126 (  __context__ , (ushort)( 0 )) ; 
        } 
    
    
    }
    
private void _147 (  SplusExecutionContext __context__, CrestronString _75 , CrestronString _76 ) 
    { 
    
    __context__.SourceCodeLine = 48;
    _124 (  __context__ , "MessageHandler", "InitialiseComms") ; 
    __context__.SourceCodeLine = 48;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_79._77 != 0))  ) ) 
        { 
        __context__.SourceCodeLine = 48;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_79._75 != "") ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_79._75 != _75) ) || Functions.TestForTrue ( Functions.BoolToInt (_79._76 != _76) )) ) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 48;
            _146 (  __context__  ) ; 
            }
        
        } 
    
    __context__.SourceCodeLine = 48;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_79._77 == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 48;
        _79 . _75  .UpdateValue ( _75  ) ; 
        __context__.SourceCodeLine = 48;
        _79 . _76  .UpdateValue ( _76  ) ; 
        __context__.SourceCodeLine = 48;
        _134 (  __context__  ) ; 
        } 
    
    
    }
    
private void _148 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 48;
    _143 (  __context__ , " ", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    
    }
    
private void _149 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 48;
    _79 . _72  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 48;
    _79 . _73 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 48;
    _79 . _74 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 48;
    _79 . _75  .UpdateValue ( P_SWITCHIP  ) ; 
    __context__.SourceCodeLine = 49;
    _79 . _76  .UpdateValue ( P_SWITCHPORT  ) ; 
    __context__.SourceCodeLine = 49;
    _79 . _77 = (ushort) ( Functions.ToInteger( -( 1 ) ) ) ; 
    __context__.SourceCodeLine = 49;
    _126 (  __context__ , (ushort)( 0 )) ; 
    
    }
    
private void _150 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 49;
    CreateWait ( "LICENCE_TEXT" , 1000 , LICENCE_TEXT_Callback ) ;
    
    }
    
public void LICENCE_TEXT_CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            CrestronString OPERATIONSTATE;
            OPERATIONSTATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            uint IMINUTESREMAINING = 0;
            
            __context__.SourceCodeLine = 49;
            IMINUTESREMAINING = (uint) ( _69( __context__ , (uint)( _86._82 ) ) ) ; 
            __context__.SourceCodeLine = 49;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_79._77 == 5))  ) ) 
                { 
                __context__.SourceCodeLine = 49;
                _79 . _78  .UpdateValue ( "DEMO (" + Functions.LtoA (  (int) ( IMINUTESREMAINING ) ) + " mins) "  ) ; 
                __context__.SourceCodeLine = 49;
                OPERATIONSTATE  .UpdateValue ( _79 . _78 + Functions.ItoA (  (int) ( _86._83 ) ) + " x " + Functions.ItoA (  (int) ( _86._84 ) )  ) ; 
                __context__.SourceCodeLine = 49;
                _124 (  __context__ , "DemoTimer", OPERATIONSTATE) ; 
                __context__.SourceCodeLine = 49;
                OPERATIONFB__DOLLAR__  .UpdateValue ( OPERATIONSTATE  ) ; 
                } 
            
            __context__.SourceCodeLine = 49;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMINUTESREMAINING == 0))  ) ) 
                {
                __context__.SourceCodeLine = 49;
                _86 . _81 = (ushort) ( 3 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 49;
                _150 (  __context__  ) ; 
                }
            
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private ushort _151 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 49;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_86._81 == 1))  ) ) 
        {
        __context__.SourceCodeLine = 49;
        return (ushort)( 65535) ; 
        }
    
    __context__.SourceCodeLine = 49;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_69( __context__ , (uint)( _86._82 ) ) == 0))  ) ) 
        {
        __context__.SourceCodeLine = 49;
        return (ushort)( 0) ; 
        }
    
    __context__.SourceCodeLine = 49;
    CancelWait ( "LICENCE_TEXT" ) ; 
    __context__.SourceCodeLine = 50;
    _150 (  __context__  ) ; 
    __context__.SourceCodeLine = 50;
    return (ushort)( 65535) ; 
    
    }
    
private void _152 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 50;
    _147 (  __context__ , P_SWITCHIP , P_SWITCHPORT ) ; 
    
    }
    
private void _153 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 50;
    _124 (  __context__ , " fnLuxulSwitch_handleSaveStatus", "") ; 
    __context__.SourceCodeLine = 50;
    _143 (  __context__ , "copy running-config startup-config", (ushort)( 0 ), "Building configuration...", (ushort)( 0 ), "") ; 
    
    }
    
private ushort _154 (  SplusExecutionContext __context__, CrestronString _156 , short _157 , short [,] _158 , ref CrestronString [] _159 ) 
    { 
    short _160 = 0;
    
    ushort _161 = 0;
    ushort _162 = 0;
    ushort _163 = 0;
    ushort _164 = 0;
    ushort _165 = 0;
    ushort _166 = 0;
    ushort _167 = 0;
    ushort _168 = 0;
    ushort POS = 0;
    
    CrestronString _169;
    CrestronString _170;
    CrestronString _171;
    _169  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _170  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 254, this );
    _171  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    _0 _172;
    _172  = new _0( this, true );
    _172 .PopulateCustomAttributeList( false );
    
    
    __context__.SourceCodeLine = 50;
    _160 = (short) ( 0 ) ; 
    __context__.SourceCodeLine = 50;
    _161 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 50;
    _162 = (ushort) ( Functions.Length( _156 ) ) ; 
    __context__.SourceCodeLine = 50;
    do 
        { 
        __context__.SourceCodeLine = 50;
        POS = (ushort) ( Functions.Find( "," , _156 , _161 ) ) ; 
        __context__.SourceCodeLine = 50;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POS == 0))  ) ) 
            {
            __context__.SourceCodeLine = 50;
            _163 = (ushort) ( _162 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 50;
            _163 = (ushort) ( POS ) ; 
            }
        
        __context__.SourceCodeLine = 51;
        _170  .UpdateValue ( "gi(%d*)/?(%d*)/?(%d*)-?(%d*)"  ) ; 
        __context__.SourceCodeLine = 51;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _37( __context__ , _156 , (ushort)( _163 ) , (short)( _161 ) , _170 , (ushort)( Functions.Length( _170 ) ) , ref _172 ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 51;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _172._4[ 3 ] > _172._3[ 3 ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 51;
                _165 = (ushort) ( (Functions.Atoi( _125( __context__ , _156 , (ushort)( _172._3[ 1 ] ) , (ushort)( _172._4[ 1 ] ) ) ) - 1) ) ; 
                __context__.SourceCodeLine = 51;
                _166 = (ushort) ( 3 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 51;
                _165 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 51;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _172._4[ 2 ] > _172._3[ 2 ] ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 51;
                    _166 = (ushort) ( 2 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 51;
                    _166 = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 51;
            _167 = (ushort) ( Functions.Atoi( _125( __context__ , _156 , (ushort)( _172._3[ _166 ] ) , (ushort)( _172._4[ _166 ] ) ) ) ) ; 
            __context__.SourceCodeLine = 51;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _172._4[ 4 ] > _172._3[ 4 ] ))  ) ) 
                {
                __context__.SourceCodeLine = 51;
                _168 = (ushort) ( Functions.Atoi( _125( __context__ , _156 , (ushort)( _172._3[ 4 ] ) , (ushort)( _172._4[ 4 ] ) ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 51;
                _168 = (ushort) ( _167 ) ; 
                }
            
            __context__.SourceCodeLine = 51;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _167 < 1 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _168 > 52 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _167 > _168 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _165 < 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _165 >= 8 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 51;
                _124 (  __context__ , "_recordPortsInMap", "Invalid port name in VLAN port list") ; 
                __context__.SourceCodeLine = 51;
                _160 = (short) ( Functions.ToSignedInteger( -( 1000 ) ) ) ; 
                __context__.SourceCodeLine = 51;
                break ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 52;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( _159[ _165 ] ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 52;
                    _159 [ _165]  .UpdateValue ( _156  ) ; 
                    __context__.SourceCodeLine = 52;
                    _159 [ _165]  .UpdateValue ( Functions.Mid ( _159 [ _165] ,  (int) ( _161 ) ,  (int) ( (_172._3[ _166 ] - _161) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 52;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( _167 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)_168; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( _164  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_164  >= __FN_FORSTART_VAL__1) && (_164  <= __FN_FOREND_VAL__1) ) : ( (_164  <= __FN_FORSTART_VAL__1) && (_164  >= __FN_FOREND_VAL__1) ) ; _164  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 52;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_158[ _165 , _164 ] == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 52;
                        _158 [ _165 , _164] = (short) ( _157 ) ; 
                        __context__.SourceCodeLine = 52;
                        _160 = (short) ( (_160 + 1) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 52;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_158[ _165 , _164 ] != Functions.ToSignedLongInteger( -( _157 ) )))  ) ) 
                            { 
                            __context__.SourceCodeLine = 52;
                            _124 (  __context__ , "_recordPortsInMap", "Port appears on more than one TX VLAN") ; 
                            __context__.SourceCodeLine = 52;
                            _160 = (short) ( Functions.ToSignedInteger( -( 1000 ) ) ) ; 
                            } 
                        
                        }
                    
                    __context__.SourceCodeLine = 52;
                    } 
                
                __context__.SourceCodeLine = 52;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _168 > _158[ _165 , 0 ] ))  ) ) 
                    {
                    __context__.SourceCodeLine = 52;
                    _158 [ _165 , 0] = (short) ( _168 ) ; 
                    }
                
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 52;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_163 != _161))  ) ) 
                { 
                __context__.SourceCodeLine = 52;
                _124 (  __context__ , "_recordPortsInMap", "Unexpected port list format") ; 
                __context__.SourceCodeLine = 52;
                _160 = (short) ( Functions.ToSignedInteger( -( 1000 ) ) ) ; 
                __context__.SourceCodeLine = 52;
                break ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 52;
        _161 = (ushort) ( (_163 + 1) ) ; 
        } 
    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (_163 == _162)) )); 
    __context__.SourceCodeLine = 52;
    return (ushort)( _160) ; 
    
    }
    
private void _155 (  SplusExecutionContext __context__, ushort _157 , CrestronString _158 ) 
    { 
    CrestronString _159;
    CrestronString _160;
    _159  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _160  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    
    
    __context__.SourceCodeLine = 53;
    if ( Functions.TestForTrue  ( ( Functions.Not( _151( __context__ ) ))  ) ) 
        {
        __context__.SourceCodeLine = 53;
        return ; 
        }
    
    __context__.SourceCodeLine = 53;
    _159  .UpdateValue ( "10," + Functions.ItoA (  (int) ( (_157 + 10) ) )  ) ; 
    __context__.SourceCodeLine = 53;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_158 != ""))  ) ) 
        { 
        __context__.SourceCodeLine = 53;
        _144 (  __context__ , "con ter", (ushort)( 0 ), "(config)#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 53;
        MakeString ( _160 , "in gi {0}", _158 ) ; 
        __context__.SourceCodeLine = 53;
        _144 (  __context__ , _160, (ushort)( 0 ), "(config-if)#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 53;
        MakeString ( _160 , "switch hy all vlan {0}", _159 ) ; 
        __context__.SourceCodeLine = 53;
        _144 (  __context__ , _160, (ushort)( 0 ), "(config-if)#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 53;
        _144 (  __context__ , "end", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 53;
        _145 (  __context__  ) ; 
        } 
    
    
    }
    
private ushort _156 (  SplusExecutionContext __context__, ushort _158 , CrestronString [] _159 ) 
    { 
    CrestronString _160;
    CrestronString [] _161;
    _160  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _161  = new CrestronString[ 9 ];
    for( uint i = 0; i < 9; i++ )
        _161 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    
    CrestronString _162;
    _162  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    ushort _163 = 0;
    ushort _164 = 0;
    ushort _165 = 0;
    
    
    __context__.SourceCodeLine = 53;
    MakeString ( _162 , "fnLuxulSwitch_MergeRanges inputLogical={0:d} physicalRange[1]={1}", (short)_158, _159 [ 1] ) ; 
    __context__.SourceCodeLine = 54;
    _124 (  __context__ , "Luxul", _162) ; 
    __context__.SourceCodeLine = 54;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)8; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _163  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_163  >= __FN_FORSTART_VAL__1) && (_163  <= __FN_FOREND_VAL__1) ) : ( (_163  <= __FN_FORSTART_VAL__1) && (_163  >= __FN_FOREND_VAL__1) ) ; _163  += (ushort)__FN_FORSTEP_VAL__1) 
        {
        __context__.SourceCodeLine = 54;
        _161 [ 8 ]  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 54;
        }
    
    __context__.SourceCodeLine = 54;
    _164 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 54;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt (_159[ _164 ] != ""))  ) ) 
        { 
        __context__.SourceCodeLine = 54;
        _160  .UpdateValue ( _159 [ _164]  ) ; 
        __context__.SourceCodeLine = 54;
        _165 = (ushort) ( Functions.Atoi( Functions.Remove( "/" , _160 , 1 ) ) ) ; 
        __context__.SourceCodeLine = 54;
        _161 [ _165 ]  .UpdateValue ( _161 [ _165 ] + "," + _160  ) ; 
        __context__.SourceCodeLine = 54;
        _164 = (ushort) ( (_164 + 1) ) ; 
        __context__.SourceCodeLine = 54;
        } 
    
    __context__.SourceCodeLine = 54;
    ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__2 = (ushort)8; 
    int __FN_FORSTEP_VAL__2 = (int)1; 
    for ( _165  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_165  >= __FN_FORSTART_VAL__2) && (_165  <= __FN_FOREND_VAL__2) ) : ( (_165  <= __FN_FORSTART_VAL__2) && (_165  >= __FN_FOREND_VAL__2) ) ; _165  += (ushort)__FN_FORSTEP_VAL__2) 
        { 
        __context__.SourceCodeLine = 54;
        MakeString ( _162 , "Range {0:d} is {1}", (short)_165, _161 [ _165 ] ) ; 
        __context__.SourceCodeLine = 54;
        _124 (  __context__ , "Luxul", _162) ; 
        __context__.SourceCodeLine = 54;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_161[ _165 ] == ""))  ) ) 
            {
            __context__.SourceCodeLine = 54;
            continue ; 
            }
        
        __context__.SourceCodeLine = 54;
        _161 [ _165 ]  .UpdateValue ( Functions.Right ( _161 [ _165 ] ,  (int) ( (Functions.Length( _161[ _165 ] ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 54;
        MakeString ( _160 , "{0:d}/{1}", (short)_165, _161 [ _165 ] ) ; 
        __context__.SourceCodeLine = 54;
        _155 (  __context__ , (ushort)( _158 ), _160) ; 
        __context__.SourceCodeLine = 54;
        } 
    
    
    return 0; // default return value (none specified in module)
    }
    
private void _157 (  SplusExecutionContext __context__, CrestronString _159 , CrestronString _76 , CrestronString _160 ) 
    { 
    CrestronString _161;
    CrestronString _162;
    CrestronString _163;
    _161  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25, this );
    _162  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _163  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    
    __context__.SourceCodeLine = 54;
    if ( Functions.TestForTrue  ( ( Functions.Not( _151( __context__ ) ))  ) ) 
        {
        __context__.SourceCodeLine = 54;
        return ; 
        }
    
    __context__.SourceCodeLine = 54;
    _161  .UpdateValue ( _159 + "/" + _76  ) ; 
    __context__.SourceCodeLine = 55;
    MakeString ( _162 , "fnLuxulSwitch_ChangePOE() sSwitchPort={0} action={1}", _161 , _160 ) ; 
    __context__.SourceCodeLine = 55;
    _124 (  __context__ , "Luxul", _161) ; 
    __context__.SourceCodeLine = 55;
    _144 (  __context__ , "con ter", (ushort)( 0 ), "(config)#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 55;
    MakeString ( _163 , "in gi {0}", _161 ) ; 
    __context__.SourceCodeLine = 55;
    _144 (  __context__ , _163, (ushort)( 0 ), "(config-if)#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 55;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_160 == "ON"))  ) ) 
        { 
        __context__.SourceCodeLine = 55;
        _144 (  __context__ , "poe mode plus", (ushort)( 0 ), "(config-if)#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 55;
        _110 [ Functions.Atoi( _159 ) , Functions.Atoi( _76 )] = (ushort) ( 65535 ) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 55;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_160 == "OFF"))  ) ) 
            { 
            __context__.SourceCodeLine = 55;
            _144 (  __context__ , "no poe mode", (ushort)( 0 ), "(config-if)#", (ushort)( 0 ), "") ; 
            __context__.SourceCodeLine = 55;
            _110 [ Functions.Atoi( _159 ) , Functions.Atoi( _76 )] = (ushort) ( 0 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 55;
            _124 (  __context__ , "Luxul", "Invalid action.  PoE not changed") ; 
            } 
        
        }
    
    __context__.SourceCodeLine = 55;
    _144 (  __context__ , "end", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 55;
    _145 (  __context__  ) ; 
    
    }
    
private void _158 (  SplusExecutionContext __context__, ushort _160 , CrestronString _161 ) 
    { 
    ushort [] _162;
    ushort _163 = 0;
    ushort _164 = 0;
    ushort _165 = 0;
    _162  = new ushort[ 405 ];
    
    CrestronString _166;
    _166  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 404, this );
    
    CrestronString _167;
    _167  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 404, this );
    
    CrestronString _168;
    CrestronString [] _169;
    _168  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _169  = new CrestronString[ 256 ];
    for( uint i = 0; i < 256; i++ )
        _169 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    CrestronString _3;
    _3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    CrestronString _4;
    _4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    
    ushort _170 = 0;
    
    ushort _171 = 0;
    
    CrestronString _172;
    _172  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    ushort _173 = 0;
    
    CrestronString [] _174;
    _174  = new CrestronString[ 101 ];
    for( uint i = 0; i < 101; i++ )
        _174 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    CrestronString _175;
    _175  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    _0 _176;
    _176  = new _0( this, true );
    _176 .PopulateCustomAttributeList( false );
    
    
    __context__.SourceCodeLine = 56;
    if ( Functions.TestForTrue  ( ( Functions.Not( _151( __context__ ) ))  ) ) 
        {
        __context__.SourceCodeLine = 56;
        return ; 
        }
    
    __context__.SourceCodeLine = 56;
    _165 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 56;
    _166  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 56;
    _167  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 56;
    _168  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 56;
    _3  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 56;
    _4  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 56;
    _170 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 56;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)404; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _171  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_171  >= __FN_FORSTART_VAL__1) && (_171  <= __FN_FOREND_VAL__1) ) : ( (_171  <= __FN_FORSTART_VAL__1) && (_171  >= __FN_FOREND_VAL__1) ) ; _171  += (ushort)__FN_FORSTEP_VAL__1) 
        {
        __context__.SourceCodeLine = 56;
        _162 [ _171] = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 56;
        }
    
    __context__.SourceCodeLine = 56;
    MakeString ( _175 , " Input: {0:d} Output: {1}", (short)_160, _161 ) ; 
    __context__.SourceCodeLine = 56;
    _124 (  __context__ , "createRangeInterface()", _175) ; 
    __context__.SourceCodeLine = 56;
    do 
        { 
        __context__.SourceCodeLine = 56;
        _163 = (ushort) ( Functions.Find( "," , _161 , 1 ) ) ; 
        __context__.SourceCodeLine = 56;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _163 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 56;
            _172  .UpdateValue ( Functions.Remove ( "," , _161 , 1)  ) ; 
            __context__.SourceCodeLine = 56;
            _172  .UpdateValue ( Functions.Left ( _172 ,  (int) ( (Functions.Length( _172 ) - 1) ) )  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 57;
            _172  .UpdateValue ( _161  ) ; 
            } 
        
        __context__.SourceCodeLine = 57;
        _171 = (ushort) ( Functions.Atoi( _172 ) ) ; 
        __context__.SourceCodeLine = 57;
        _162 [ _171] = (ushort) ( 1 ) ; 
        } 
    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( _163 < 1 )) )); 
    __context__.SourceCodeLine = 57;
    MakeString ( _175 , " g_LuxulSwitch.readyForCommands = {0:d}", (short)_86._85) ; 
    __context__.SourceCodeLine = 57;
    _124 (  __context__ , "createRangeInterface()", _175) ; 
    __context__.SourceCodeLine = 57;
    ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__2 = (ushort)(_99 + 1); 
    int __FN_FORSTEP_VAL__2 = (int)1; 
    for ( _171  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_171  >= __FN_FORSTART_VAL__2) && (_171  <= __FN_FOREND_VAL__2) ) : ( (_171  <= __FN_FORSTART_VAL__2) && (_171  >= __FN_FOREND_VAL__2) ) ; _171  += (ushort)__FN_FORSTEP_VAL__2) 
        { 
        __context__.SourceCodeLine = 57;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( _162[ _171 ] ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _171 <= _99 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _171 > 0 ) )) ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _160 <= _98 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _160 > 0 ) )) ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 57;
            OUTPUTFB [ _171]  .Value = (ushort) ( _160 ) ; 
            __context__.SourceCodeLine = 57;
            MakeString ( _175 , " g_rxPositionOnStack[{0:d}] = : {1}", (short)_171, _108 [ _171 ] ) ; 
            __context__.SourceCodeLine = 57;
            _124 (  __context__ , "createRangeInterface  ", _175) ; 
            __context__.SourceCodeLine = 57;
            _172  .UpdateValue ( _108 [ _171 ]  ) ; 
            __context__.SourceCodeLine = 57;
            _173 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 57;
            do 
                { 
                __context__.SourceCodeLine = 57;
                _163 = (ushort) ( Functions.Find( "/" , _172 , 1 ) ) ; 
                __context__.SourceCodeLine = 57;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _163 > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 57;
                    _173 = (ushort) ( (_173 + 1) ) ; 
                    __context__.SourceCodeLine = 57;
                    _174 [ _173 ]  .UpdateValue ( Functions.Remove ( "/" , _172 , 1)  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 57;
                    _173 = (ushort) ( (_173 + 1) ) ; 
                    __context__.SourceCodeLine = 57;
                    _174 [ _173 ]  .UpdateValue ( _172  ) ; 
                    } 
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( _163 < 1 )) )); 
            __context__.SourceCodeLine = 58;
            MakeString ( _175 , " createRangeInterface()  - split2length {0:d}", (short)_173) ; 
            __context__.SourceCodeLine = 58;
            _124 (  __context__ , "createRangeInterface", _175) ; 
            __context__.SourceCodeLine = 58;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _173 > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 58;
                _168  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 58;
                _166  .UpdateValue ( _174 [ _173 ]  ) ; 
                __context__.SourceCodeLine = 58;
                ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__3 = (ushort)(_173 - 1); 
                int __FN_FORSTEP_VAL__3 = (int)1; 
                for ( _164  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (_164  >= __FN_FORSTART_VAL__3) && (_164  <= __FN_FOREND_VAL__3) ) : ( (_164  <= __FN_FORSTART_VAL__3) && (_164  >= __FN_FOREND_VAL__3) ) ; _164  += (ushort)__FN_FORSTEP_VAL__3) 
                    {
                    __context__.SourceCodeLine = 58;
                    _168  .UpdateValue ( _168 + _174 [ _164 ]  ) ; 
                    __context__.SourceCodeLine = 58;
                    }
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 58;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _38( __context__ , _108[ _171 ] , (short)( 1 ) , "gi(%d+)" , ref _176 ) > Functions.ToSignedLongInteger( -( 1 ) ) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 58;
                    _166  .UpdateValue ( _125 (  __context__ , _108[ _171 ], (ushort)( _176._3[ 1 ] ), (ushort)( _176._4[ 1 ] ))  ) ; 
                    __context__.SourceCodeLine = 58;
                    _168  .UpdateValue ( "gi"  ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 58;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_3 != ""))  ) ) 
                {
                __context__.SourceCodeLine = 58;
                _170 = (ushort) ( _38( __context__ , _3 , (short)( 1 ) , _168 , ref _176 ) ) ; 
                }
            
            __context__.SourceCodeLine = 58;
            MakeString ( _175 , "switchLogicalRange() - previousposOnSwitch: {0} posOnSwitch: {1} checkPrefix: {2:d} Prefix: {3} start:{4} ", _167 , _166 , (short)_170, _168 , _3 ) ; 
            __context__.SourceCodeLine = 58;
            _124 (  __context__ , "createRangeInterface", _175) ; 
            __context__.SourceCodeLine = 59;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ((Functions.Atoi( _167 ) + 1) == Functions.Atoi( _166 )) ) && Functions.TestForTrue ( Functions.BoolToInt (_170 != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_3 == "") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 59;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_3 == ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 59;
                    _3  .UpdateValue ( _108 [ _171 ]  ) ; 
                    __context__.SourceCodeLine = 59;
                    _4  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 59;
                    _167  .UpdateValue ( _166  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 59;
                    _4  .UpdateValue ( _166  ) ; 
                    __context__.SourceCodeLine = 59;
                    _167  .UpdateValue ( _166  ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 59;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_3 != ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 59;
                    _165 = (ushort) ( (_165 + 1) ) ; 
                    __context__.SourceCodeLine = 59;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_4 == ""))  ) ) 
                        {
                        __context__.SourceCodeLine = 59;
                        _169 [ _165 ]  .UpdateValue ( _3  ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 59;
                        _169 [ _165 ]  .UpdateValue ( _3 + "-" + _4  ) ; 
                        }
                    
                    __context__.SourceCodeLine = 59;
                    _3  .UpdateValue ( _108 [ _171 ]  ) ; 
                    __context__.SourceCodeLine = 59;
                    _4  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 59;
                    _167  .UpdateValue ( _166  ) ; 
                    } 
                
                }
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 59;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_3 != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 59;
                _165 = (ushort) ( (_165 + 1) ) ; 
                __context__.SourceCodeLine = 59;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_4 == ""))  ) ) 
                    {
                    __context__.SourceCodeLine = 59;
                    _169 [ _165 ]  .UpdateValue ( _3  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 59;
                    _169 [ _165 ]  .UpdateValue ( _3 + "-" + _4  ) ; 
                    }
                
                __context__.SourceCodeLine = 59;
                _3  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 59;
                _4  .UpdateValue ( ""  ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 57;
        } 
    
    __context__.SourceCodeLine = 59;
    if ( Functions.TestForTrue  ( ( _156( __context__ , (ushort)( _160 ) , _169 ))  ) ) 
        { 
        } 
    
    
    }
    
private void _159 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 59;
    CreateWait ( "__SPLS_TMPVAR__WAITLABEL_2__" , 200 , __SPLS_TMPVAR__WAITLABEL_2___Callback ) ;
    
    }
    
public void __SPLS_TMPVAR__WAITLABEL_2___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 59;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 0 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private void _160 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 59;
    _146 (  __context__  ) ; 
    __context__.SourceCodeLine = 59;
    _86 . _85 = (ushort) ( 0 ) ; 
    
    }
    
private void _161 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 59;
    _124 (  __context__ , "startUp", "startUp") ; 
    __context__.SourceCodeLine = 59;
    _86 . _82 = (uint) ( _68( __context__ ) ) ; 
    __context__.SourceCodeLine = 59;
    _124 (  __context__ , "Boot time:", Functions.LtoA( (int)( _86._82 ) )) ; 
    __context__.SourceCodeLine = 60;
    _149 (  __context__  ) ; 
    __context__.SourceCodeLine = 60;
    _86 . _85 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 60;
    _147 (  __context__ , P_SWITCHIP , P_SWITCHPORT ) ; 
    
    }
    
private void _162 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 60;
    _86 . _81 = (ushort) ( 2 ) ; 
    __context__.SourceCodeLine = 60;
    _86 . _83 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 60;
    _86 . _84 = (ushort) ( 0 ) ; 
    
    }
    
private ushort _163 (  SplusExecutionContext __context__, ushort _165 ) 
    { 
    ushort _166 = 0;
    ushort _167 = 0;
    ushort _168 = 0;
    ushort _169 = 0;
    ushort _170 = 0;
    
    CrestronString _171;
    CrestronString _172;
    _171  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    _172  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    
    
    __context__.SourceCodeLine = 60;
    if ( Functions.TestForTrue  ( ( Functions.Not( _151( __context__ ) ))  ) ) 
        {
        __context__.SourceCodeLine = 60;
        return (ushort)( 0) ; 
        }
    
    __context__.SourceCodeLine = 60;
    _124 (  __context__ , "fnLuxulSwitch_CreateCmdfromTables startFrom", Functions.ItoA( (int)( _165 ) )) ; 
    __context__.SourceCodeLine = 60;
    _124 (  __context__ , "fnLuxulSwitch_CreateCmdfromTables g_MessageHandlerComms.connectState", Functions.ItoA( (int)( _79._77 ) )) ; 
    __context__.SourceCodeLine = 60;
    _117 = (ushort) ( 65535 ) ; 
    __context__.SourceCodeLine = 60;
    _169 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 60;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _79._77 >= 5 ))  ) ) 
        { 
        __context__.SourceCodeLine = 60;
        _166 = (ushort) ( _165 ) ; 
        __context__.SourceCodeLine = 60;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _166 <= 1500 ))  ) ) 
            { 
            __context__.SourceCodeLine = 60;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_116[ _166 ] != _115[ _166 ]))  ) ) 
                { 
                __context__.SourceCodeLine = 60;
                _169 = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 60;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _166 < 404 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 60;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)404; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( _167  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_167  >= __FN_FORSTART_VAL__1) && (_167  <= __FN_FOREND_VAL__1) ) : ( (_167  <= __FN_FORSTART_VAL__1) && (_167  >= __FN_FOREND_VAL__1) ) ; _167  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 61;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_116[ _167 ] != _115[ _167 ]) ) && Functions.TestForTrue ( Functions.BoolToInt (_115[ _166 ] == _115[ _167 ]) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 61;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_171 != ""))  ) ) 
                                {
                                __context__.SourceCodeLine = 61;
                                _171  .UpdateValue ( _171 + "," + Functions.ItoA (  (int) ( _167 ) )  ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 61;
                                _171  .UpdateValue ( Functions.ItoA (  (int) ( _167 ) )  ) ; 
                                }
                            
                            __context__.SourceCodeLine = 61;
                            _116 [ _167 ]  .UpdateValue ( _115 [ _167 ]  ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 60;
                        } 
                    
                    __context__.SourceCodeLine = 61;
                    _158 (  __context__ , (ushort)( Functions.Atoi( _116[ _166 ] ) ), _171) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 61;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _166 > (404 + 1) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _166 < 1380 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 61;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _166 >= 500 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _166 < 610 ) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 61;
                            _170 = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 61;
                            _168 = (ushort) ( (_166 - 500) ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 61;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _166 >= 610 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _166 < 720 ) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 61;
                                _170 = (ushort) ( 2 ) ; 
                                __context__.SourceCodeLine = 61;
                                _168 = (ushort) ( (_166 - 610) ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 61;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _166 >= 720 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _166 < 830 ) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 61;
                                    _170 = (ushort) ( 3 ) ; 
                                    __context__.SourceCodeLine = 61;
                                    _168 = (ushort) ( (_166 - 720) ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 61;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _166 >= 830 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _166 < 940 ) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 61;
                                        _170 = (ushort) ( 4 ) ; 
                                        __context__.SourceCodeLine = 61;
                                        _168 = (ushort) ( (_166 - 830) ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 61;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _166 >= 940 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _166 < 1050 ) )) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 61;
                                            _170 = (ushort) ( 5 ) ; 
                                            __context__.SourceCodeLine = 61;
                                            _168 = (ushort) ( (_166 - 940) ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 61;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _166 >= 1050 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _166 < 1160 ) )) ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 61;
                                                _170 = (ushort) ( 6 ) ; 
                                                __context__.SourceCodeLine = 61;
                                                _168 = (ushort) ( (_166 - 1050) ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 62;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _166 >= 1160 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _166 < 1270 ) )) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 62;
                                                    _170 = (ushort) ( 7 ) ; 
                                                    __context__.SourceCodeLine = 62;
                                                    _168 = (ushort) ( (_166 - 1160) ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 62;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _166 >= 1270 ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 62;
                                                        _170 = (ushort) ( 8 ) ; 
                                                        __context__.SourceCodeLine = 62;
                                                        _168 = (ushort) ( (_166 - 1270) ) ; 
                                                        } 
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        __context__.SourceCodeLine = 62;
                        _124 (  __context__ , "fnLuxulSwitch_CreateCmdfromTables index", Functions.ItoA( (int)( _168 ) )) ; 
                        __context__.SourceCodeLine = 62;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _168 > 52 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 62;
                            _168 = (ushort) ( (_168 - 52) ) ; 
                            __context__.SourceCodeLine = 62;
                            _172  .UpdateValue ( "OFF"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 62;
                            _172  .UpdateValue ( "ON"  ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 62;
                        _115 [ _166 ]  .UpdateValue ( "0"  ) ; 
                        __context__.SourceCodeLine = 62;
                        _157 (  __context__ , Functions.ItoA( (int)( _170 ) ), Functions.ItoA( (int)( _168 ) ), _172) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 62;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_166 == 1381))  ) ) 
                            { 
                            __context__.SourceCodeLine = 62;
                            _112 = (ushort) ( 65535 ) ; 
                            __context__.SourceCodeLine = 62;
                            _143 (  __context__ , "show vlan", (ushort)( 11 ), "#", (ushort)( 0 ), "") ; 
                            __context__.SourceCodeLine = 62;
                            _115 [ _166 ]  .UpdateValue ( "0"  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 62;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_166 == 1382))  ) ) 
                                { 
                                __context__.SourceCodeLine = 62;
                                _143 (  __context__ , "show vlan", (ushort)( 11 ), "#", (ushort)( 0 ), "") ; 
                                __context__.SourceCodeLine = 62;
                                _115 [ _166 ]  .UpdateValue ( "0"  ) ; 
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 62;
                break ; 
                } 
            
            __context__.SourceCodeLine = 62;
            _166 = (ushort) ( (_166 + 1) ) ; 
            __context__.SourceCodeLine = 62;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _166 > 1500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 62;
                if ( Functions.TestForTrue  ( ( _120)  ) ) 
                    { 
                    __context__.SourceCodeLine = 62;
                    _120 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 62;
                    _166 = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 62;
                    _106 = (ushort) ( 65535 ) ; 
                    __context__.SourceCodeLine = 62;
                    _117 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 62;
                    _166 = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 62;
                    break ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 60;
            } 
        
        } 
    
    __context__.SourceCodeLine = 63;
    _124 (  __context__ , "fnLuxulSwitch_CreateCmdfromTables return i", Functions.ItoA( (int)( _166 ) )) ; 
    __context__.SourceCodeLine = 63;
    return (ushort)( _166) ; 
    
    }
    
private void _164 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 63;
    if ( Functions.TestForTrue  ( ( Functions.Not( _151( __context__ ) ))  ) ) 
        {
        __context__.SourceCodeLine = 63;
        return ; 
        }
    
    __context__.SourceCodeLine = 63;
    _124 (  __context__ , "fnTriggerChangedStatus g_processingCmdTable", Functions.ItoA( (int)( _117 ) )) ; 
    __context__.SourceCodeLine = 63;
    if ( Functions.TestForTrue  ( ( _117)  ) ) 
        { 
        __context__.SourceCodeLine = 63;
        _120 = (ushort) ( 65535 ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 63;
        _106 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 63;
        if ( Functions.TestForTrue  ( ( _86._85)  ) ) 
            {
            __context__.SourceCodeLine = 63;
            _118 = (ushort) ( _163( __context__ , (ushort)( 1 ) ) ) ; 
            }
        
        } 
    
    
    }
    
private void _165 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 63;
    _124 (  __context__ , "fnLuxulSwitch_beginOperations ", "fnLuxulSwitch_beginOperations") ; 
    __context__.SourceCodeLine = 63;
    _126 (  __context__ , (ushort)( 6 )) ; 
    __context__.SourceCodeLine = 63;
    _124 (  __context__ , "fnLuxulSwitch_loggedOn", "fnLuxulSwitch_loggedOn") ; 
    __context__.SourceCodeLine = 63;
    _143 (  __context__ , "con ter", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 63;
    _143 (  __context__ , "ip routing", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 63;
    _143 (  __context__ , "exit", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 63;
    _143 (  __context__ , "terminal width 0", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 64;
    _143 (  __context__ , "terminal length 0", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 64;
    _143 (  __context__ , "show vlan", (ushort)( 10 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 64;
    _143 (  __context__ , "show version", (ushort)( 12 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 64;
    _143 (  __context__ , "show poe", (ushort)( 13 ), "#", (ushort)( 0 ), "") ; 
    
    }
    
private void _166 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 64;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_86._81 == 1))  ) ) 
        {
        __context__.SourceCodeLine = 64;
        _79 . _78  .UpdateValue ( ""  ) ; 
        }
    
    else 
        {
        __context__.SourceCodeLine = 64;
        _79 . _78  .UpdateValue ( "DEMO "  ) ; 
        }
    
    __context__.SourceCodeLine = 64;
    _86 . _85 = (ushort) ( 65535 ) ; 
    __context__.SourceCodeLine = 64;
    _106 = (ushort) ( 65535 ) ; 
    __context__.SourceCodeLine = 64;
    _126 (  __context__ , (ushort)( 5 )) ; 
    __context__.SourceCodeLine = 64;
    _117 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 64;
    _118 = (ushort) ( _163( __context__ , (ushort)( 1 ) ) ) ; 
    
    }
    
private void _167 (  SplusExecutionContext __context__ ) 
    { 
    ushort _169 = 0;
    ushort _170 = 0;
    
    CrestronString _171;
    CrestronString _172;
    CrestronString _173;
    CrestronString _174;
    _171  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _172  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _173  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
    _174  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
    
    CrestronString _175;
    CrestronString _176;
    _175  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    _176  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    ushort _177 = 0;
    
    ushort _178 = 0;
    
    ushort [] _179;
    _179  = new ushort[ 17 ];
    
    CrestronString [] _180;
    _180  = new CrestronString[ 17 ];
    for( uint i = 0; i < 17; i++ )
        _180 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    
    __context__.SourceCodeLine = 64;
    _173  .UpdateValue ( _107  ) ; 
    __context__.SourceCodeLine = 64;
    _124 (  __context__ , "checkLicence rxDataMac ", _173) ; 
    __context__.SourceCodeLine = 64;
    while ( Functions.TestForTrue  ( ( Functions.Find( "License Activation is :" , _173 ))  ) ) 
        {
        __context__.SourceCodeLine = 65;
        _174  .UpdateValue ( Functions.Remove ( "License Activation is :" , _173 )  ) ; 
        __context__.SourceCodeLine = 64;
        }
    
    __context__.SourceCodeLine = 65;
    _124 (  __context__ , "checkLicence rxDataMac1 ", _173) ; 
    __context__.SourceCodeLine = 65;
    _173  .UpdateValue ( Functions.Remove ( "\u000A\u000D" , _173 )  ) ; 
    __context__.SourceCodeLine = 65;
    _124 (  __context__ , "checkLicence rxDataMac2 ", _173) ; 
    __context__.SourceCodeLine = 65;
    _175  .UpdateValue ( Functions.Left ( _173 ,  (int) ( (Functions.Length( _173 ) - 2) ) )  ) ; 
    __context__.SourceCodeLine = 65;
    CRESTRONID__DOLLAR__  .UpdateValue ( _173  ) ; 
    __context__.SourceCodeLine = 65;
    _178 = (ushort) ( 16 ) ; 
    __context__.SourceCodeLine = 65;
    _177 = (ushort) ( _65( __context__ , P_SWITCHLICENCEKEY  , (ushort)( _178 ) , ref _179 , ref _180 ) ) ; 
    __context__.SourceCodeLine = 65;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)_177; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _170  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_170  >= __FN_FORSTART_VAL__1) && (_170  <= __FN_FOREND_VAL__1) ) : ( (_170  <= __FN_FORSTART_VAL__1) && (_170  >= __FN_FOREND_VAL__1) ) ; _170  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 65;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_179[ _170 ] == 6))  ) ) 
            { 
            __context__.SourceCodeLine = 65;
            _171  .UpdateValue ( _66 (  __context__ , _180[ _170 ])  ) ; 
            __context__.SourceCodeLine = 65;
            _172  .UpdateValue ( _66 (  __context__ , _175)  ) ; 
            __context__.SourceCodeLine = 65;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_172 == _171))  ) ) 
                {
                __context__.SourceCodeLine = 65;
                _86 . _81 = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 65;
                _86 . _81 = (ushort) ( 2 ) ; 
                }
            
            __context__.SourceCodeLine = 65;
            break ; 
            } 
        
        __context__.SourceCodeLine = 65;
        } 
    
    __context__.SourceCodeLine = 65;
    if ( Functions.TestForTrue  ( ( _86._81)  ) ) 
        { 
        __context__.SourceCodeLine = 65;
        _86 . _81 = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 65;
        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__2 = (ushort)_177; 
        int __FN_FORSTEP_VAL__2 = (int)1; 
        for ( _170  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_170  >= __FN_FORSTART_VAL__2) && (_170  <= __FN_FOREND_VAL__2) ) : ( (_170  <= __FN_FORSTART_VAL__2) && (_170  >= __FN_FOREND_VAL__2) ) ; _170  += (ushort)__FN_FORSTEP_VAL__2) 
            { 
            __context__.SourceCodeLine = 65;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_179[ _170 ] == 4))  ) ) 
                { 
                __context__.SourceCodeLine = 65;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_180[ _170 ] == "JADDriver"))  ) ) 
                    {
                    __context__.SourceCodeLine = 65;
                    _86 . _81 = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 65;
                break ; 
                } 
            
            __context__.SourceCodeLine = 65;
            } 
        
        } 
    
    __context__.SourceCodeLine = 65;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_86._81 == 1))  ) ) 
        {
        __context__.SourceCodeLine = 65;
        _176  .UpdateValue ( "Licensed"  ) ; 
        }
    
    else 
        {
        __context__.SourceCodeLine = 66;
        _176  .UpdateValue ( "Demo license"  ) ; 
        }
    
    __context__.SourceCodeLine = 66;
    _124 (  __context__ , "checkLicence", _176) ; 
    __context__.SourceCodeLine = 66;
    _86 . _83 = (ushort) ( _98 ) ; 
    __context__.SourceCodeLine = 66;
    _86 . _84 = (ushort) ( _99 ) ; 
    __context__.SourceCodeLine = 66;
    _105 = (ushort) ( (_98 + _99) ) ; 
    __context__.SourceCodeLine = 66;
    NUMOFINPUTS  .Value = (ushort) ( _86._83 ) ; 
    __context__.SourceCodeLine = 66;
    NUMOFOUTPUTS  .Value = (ushort) ( _86._84 ) ; 
    
    }
    
private void _168 (  SplusExecutionContext __context__, CrestronString _170 , CrestronString [] _171 , ushort _172 , ushort _173 ) 
    { 
    ushort _174 = 0;
    
    
    __context__.SourceCodeLine = 66;
    _171 [ 1]  .UpdateValue ( Functions.Mid ( _170 ,  (int) ( 1 ) ,  (int) ( (_172 - 1) ) )  ) ; 
    __context__.SourceCodeLine = 66;
    _171 [ 2]  .UpdateValue ( Functions.Mid ( _170 ,  (int) ( _172 ) ,  (int) ( ((_173 - _172) - 1) ) )  ) ; 
    __context__.SourceCodeLine = 66;
    _171 [ 3]  .UpdateValue ( Functions.Right ( _170 ,  (int) ( ((Functions.Length( _170 ) - _173) + 1) ) )  ) ; 
    __context__.SourceCodeLine = 66;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Right( _171[ 3 ] , (int)( 2 ) ) == "\r\n"))  ) ) 
        {
        __context__.SourceCodeLine = 66;
        _171 [ 3]  .UpdateValue ( Functions.Left ( _171 [ 3] ,  (int) ( (Functions.Length( _171[ 3 ] ) - 2) ) )  ) ; 
        }
    
    __context__.SourceCodeLine = 66;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)2; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _174  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_174  >= __FN_FORSTART_VAL__1) && (_174  <= __FN_FOREND_VAL__1) ) : ( (_174  <= __FN_FORSTART_VAL__1) && (_174  >= __FN_FOREND_VAL__1) ) ; _174  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 66;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Right( _171[ _174 ] , (int)( 1 ) ) == " ") ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _171[ _174 ] ) > 0 ) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 66;
            _171 [ _174]  .UpdateValue ( Functions.Left ( _171 [ _174] ,  (int) ( (Functions.Length( _171[ _174 ] ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 66;
            }
        
        __context__.SourceCodeLine = 66;
        } 
    
    
    }
    
private ushort _169 (  SplusExecutionContext __context__, CrestronString _171 , ushort _172 , CrestronString _173 , CrestronString _174 ) 
    { 
    CrestronString _175;
    _175  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    ushort _176 = 0;
    
    
    __context__.SourceCodeLine = 67;
    _175  .UpdateValue ( _171  ) ; 
    __context__.SourceCodeLine = 67;
    _174  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 67;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( _175 ); 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _176  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_176  >= __FN_FORSTART_VAL__1) && (_176  <= __FN_FOREND_VAL__1) ) : ( (_176  <= __FN_FORSTART_VAL__1) && (_176  >= __FN_FOREND_VAL__1) ) ; _176  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 67;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _175 , (int)( _176 ) ) == _172))  ) ) 
            { 
            __context__.SourceCodeLine = 67;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_173 != ""))  ) ) 
                {
                __context__.SourceCodeLine = 67;
                _174  .UpdateValue ( _174 + _173  ) ; 
                }
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 67;
            _174  .UpdateValue ( _174 + Functions.Chr (  (int) ( Byte( _175 , (int)( _176 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 67;
        } 
    
    
    return 0; // default return value (none specified in module)
    }
    
private ushort _170 (  SplusExecutionContext __context__, CrestronString _172 , ushort _173 , CrestronString [] _174 ) 
    { 
    CrestronString _175;
    _175  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    ushort _176 = 0;
    ushort _177 = 0;
    
    
    __context__.SourceCodeLine = 67;
    _175  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 67;
    _177 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 67;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( _172 ); 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _176  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_176  >= __FN_FORSTART_VAL__1) && (_176  <= __FN_FOREND_VAL__1) ) : ( (_176  <= __FN_FORSTART_VAL__1) && (_176  >= __FN_FOREND_VAL__1) ) ; _176  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 67;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _172 , (int)( _176 ) ) == _173))  ) ) 
            { 
            __context__.SourceCodeLine = 67;
            _174 [ _177]  .UpdateValue ( _175  ) ; 
            __context__.SourceCodeLine = 67;
            _177 = (ushort) ( (_177 + 1) ) ; 
            __context__.SourceCodeLine = 67;
            _175  .UpdateValue ( ""  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 67;
            _175  .UpdateValue ( _175 + Functions.Chr (  (int) ( Byte( _172 , (int)( _176 ) ) ) )  ) ; 
            } 
        
        __context__.SourceCodeLine = 67;
        } 
    
    __context__.SourceCodeLine = 67;
    _174 [ _177]  .UpdateValue ( _175  ) ; 
    __context__.SourceCodeLine = 67;
    return (ushort)( _177) ; 
    
    }
    
private ushort _171 (  SplusExecutionContext __context__, CrestronString _173 , ushort [] _174 ) 
    { 
    CrestronString _175;
    _175  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    CrestronString [] _176;
    _176  = new CrestronString[ 101 ];
    for( uint i = 0; i < 101; i++ )
        _176 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    ushort _177 = 0;
    ushort _178 = 0;
    ushort _179 = 0;
    
    ushort _180 = 0;
    ushort _181 = 0;
    ushort _182 = 0;
    
    ushort _183 = 0;
    
    
    __context__.SourceCodeLine = 68;
    _183 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 68;
    _169 (  __context__ , _173, (ushort)( Byte( " " , (int)( 1 ) ) ), "", _175) ; 
    __context__.SourceCodeLine = 68;
    _182 = (ushort) ( _170( __context__ , _175 , (ushort)( Byte( "," , (int)( 1 ) ) ) , _176 ) ) ; 
    __context__.SourceCodeLine = 68;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)_182; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _181  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_181  >= __FN_FORSTART_VAL__1) && (_181  <= __FN_FOREND_VAL__1) ) : ( (_181  <= __FN_FORSTART_VAL__1) && (_181  >= __FN_FOREND_VAL__1) ) ; _181  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 68;
        _180 = (ushort) ( Functions.Find( "-" , _176[ _181 ] , 1 ) ) ; 
        __context__.SourceCodeLine = 68;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_180 == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 68;
            _177 = (ushort) ( Functions.Atoi( _176[ _181 ] ) ) ; 
            __context__.SourceCodeLine = 68;
            _174 [ _183] = (ushort) ( _177 ) ; 
            __context__.SourceCodeLine = 68;
            _183 = (ushort) ( (_183 + 1) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 68;
            _178 = (ushort) ( Functions.Atoi( Functions.Left( _176[ _181 ] , (int)( _180 ) ) ) ) ; 
            __context__.SourceCodeLine = 68;
            _179 = (ushort) ( Functions.Atoi( Functions.Right( _176[ _181 ] , (int)( (Functions.Length( _176[ _181 ] ) - _180) ) ) ) ) ; 
            __context__.SourceCodeLine = 68;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( _178 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)_179; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( _177  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_177  >= __FN_FORSTART_VAL__2) && (_177  <= __FN_FOREND_VAL__2) ) : ( (_177  <= __FN_FORSTART_VAL__2) && (_177  >= __FN_FOREND_VAL__2) ) ; _177  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 68;
                _174 [ _183] = (ushort) ( _177 ) ; 
                __context__.SourceCodeLine = 68;
                _183 = (ushort) ( (_183 + 1) ) ; 
                __context__.SourceCodeLine = 68;
                } 
            
            } 
        
        __context__.SourceCodeLine = 68;
        } 
    
    __context__.SourceCodeLine = 68;
    return (ushort)( (_183 - 1)) ; 
    
    }
    
private ushort _172 (  SplusExecutionContext __context__, CrestronString _174 ) 
    { 
    ushort _175 = 0;
    
    
    __context__.SourceCodeLine = 69;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)250; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _175  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_175  >= __FN_FORSTART_VAL__1) && (_175  <= __FN_FOREND_VAL__1) ) : ( (_175  <= __FN_FORSTART_VAL__1) && (_175  >= __FN_FOREND_VAL__1) ) ; _175  += (ushort)__FN_FORSTEP_VAL__1) 
        {
        __context__.SourceCodeLine = 69;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_108[ _175 ] == _174))  ) ) 
            {
            __context__.SourceCodeLine = 69;
            return (ushort)( _175) ; 
            }
        
        __context__.SourceCodeLine = 69;
        }
    
    __context__.SourceCodeLine = 69;
    return (ushort)( 0) ; 
    
    }
    
private ushort _173 (  SplusExecutionContext __context__, CrestronString _175 ) 
    { 
    ushort _176 = 0;
    
    
    __context__.SourceCodeLine = 69;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)250; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _176  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_176  >= __FN_FORSTART_VAL__1) && (_176  <= __FN_FOREND_VAL__1) ) : ( (_176  <= __FN_FORSTART_VAL__1) && (_176  >= __FN_FOREND_VAL__1) ) ; _176  += (ushort)__FN_FORSTEP_VAL__1) 
        {
        __context__.SourceCodeLine = 69;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_109[ _176 ] == _175))  ) ) 
            {
            __context__.SourceCodeLine = 69;
            return (ushort)( _176) ; 
            }
        
        __context__.SourceCodeLine = 69;
        }
    
    __context__.SourceCodeLine = 69;
    return (ushort)( 0) ; 
    
    }
    
private ushort _174 (  SplusExecutionContext __context__, CrestronString _176 ) 
    { 
    CrestronString _177;
    _177  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64000, this );
    
    CrestronString [] _178;
    CrestronString _179;
    CrestronString _180;
    _179  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    _180  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    _178  = new CrestronString[ 6 ];
    for( uint i = 0; i < 6; i++ )
        _178 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    CrestronString [] _181;
    _181  = new CrestronString[ 501 ];
    for( uint i = 0; i < 501; i++ )
        _181 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    CrestronString _182;
    _182  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    CrestronString _183;
    CrestronString _184;
    _183  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _184  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    ushort _185 = 0;
    ushort _186 = 0;
    ushort _187 = 0;
    ushort _188 = 0;
    ushort _189 = 0;
    
    ushort [] _190;
    _190  = new ushort[ 51 ];
    
    ushort _191 = 0;
    
    ushort _192 = 0;
    ushort _193 = 0;
    ushort _194 = 0;
    
    ushort _195 = 0;
    ushort _196 = 0;
    
    
    __context__.SourceCodeLine = 69;
    _177  .UpdateValue ( _176  ) ; 
    __context__.SourceCodeLine = 69;
    _192 = (ushort) ( 65535 ) ; 
    __context__.SourceCodeLine = 69;
    _191 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 70;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\r\n" , _177 , 1 ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 70;
        _179  .UpdateValue ( Functions.Remove ( "\r\n" , _177 , 1)  ) ; 
        __context__.SourceCodeLine = 70;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_179 == "") ) || Functions.TestForTrue ( Functions.BoolToInt (_179 == "\r\n") )) ))  ) ) 
            {
            __context__.SourceCodeLine = 70;
            continue ; 
            }
        
        __context__.SourceCodeLine = 70;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _179 , (int)( 4 ) ) == "VLAN"))  ) ) 
            { 
            __context__.SourceCodeLine = 70;
            _195 = (ushort) ( Functions.Find( "Name" , _179 , 1 ) ) ; 
            __context__.SourceCodeLine = 70;
            _196 = (ushort) ( Functions.Find( "Interface" , _179 , 1 ) ) ; 
            __context__.SourceCodeLine = 70;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_195 == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (_196 == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 70;
                _124 (  __context__ , "Luxul_FillPosition", "Couldn't find Name and Interface in VLAN table") ; 
                __context__.SourceCodeLine = 70;
                break ; 
                } 
            
            __context__.SourceCodeLine = 70;
            continue ; 
            } 
        
        __context__.SourceCodeLine = 70;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _179 , (int)( 4 ) ) == "----"))  ) ) 
            {
            __context__.SourceCodeLine = 70;
            continue ; 
            }
        
        __context__.SourceCodeLine = 70;
        _168 (  __context__ , _179, _178, (ushort)( _195 ), (ushort)( _196 )) ; 
        __context__.SourceCodeLine = 70;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _179 , (int)( 1 ) ) == " "))  ) ) 
            { 
            __context__.SourceCodeLine = 70;
            _178 [ 2 ]  .UpdateValue ( _182  ) ; 
            __context__.SourceCodeLine = 70;
            _194 = (ushort) ( 65535 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 70;
            _182  .UpdateValue ( _178 [ 2 ]  ) ; 
            __context__.SourceCodeLine = 70;
            _194 = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 70;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _178[ 2 ] , (int)( 4 ) ) == "JAP_"))  ) ) 
            { 
            __context__.SourceCodeLine = 70;
            if ( Functions.TestForTrue  ( ( Functions.Not( _194 ))  ) ) 
                { 
                __context__.SourceCodeLine = 70;
                _183  .UpdateValue ( Functions.Right ( _178 [ 2 ] ,  (int) ( (Functions.Length( _178[ 2 ] ) - 4) ) )  ) ; 
                __context__.SourceCodeLine = 70;
                _98 = (ushort) ( Functions.Atoi( Functions.Remove( "x" , _183 , 1 ) ) ) ; 
                __context__.SourceCodeLine = 71;
                _99 = (ushort) ( Functions.Atoi( _183 ) ) ; 
                __context__.SourceCodeLine = 71;
                MakeString ( _184 , "JAP found with {0:d} TX and {1:d} RX", (short)_98, (short)_99) ; 
                __context__.SourceCodeLine = 71;
                _124 (  __context__ , "Luxul_FillPosition", _184) ; 
                } 
            
            __context__.SourceCodeLine = 71;
            _183  .UpdateValue ( Functions.Right ( _178 [ 3 ] ,  (int) ( (Functions.Length( _178[ 3 ] ) - 3) ) )  ) ; 
            __context__.SourceCodeLine = 71;
            _186 = (ushort) ( Functions.Atoi( Functions.Remove( "/" , _183 , 1 ) ) ) ; 
            __context__.SourceCodeLine = 71;
            _188 = (ushort) ( _171( __context__ , _183 , (ushort[])( _190 ) ) ) ; 
            __context__.SourceCodeLine = 71;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_188; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _185  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_185  >= __FN_FORSTART_VAL__1) && (_185  <= __FN_FOREND_VAL__1) ) : ( (_185  <= __FN_FORSTART_VAL__1) && (_185  >= __FN_FOREND_VAL__1) ) ; _185  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 71;
                MakeString ( _183 , "{0:d}/{1:d}", (short)_186, (short)_190[ _185 ]) ; 
                __context__.SourceCodeLine = 71;
                _181 [ _191 ]  .UpdateValue ( _183  ) ; 
                __context__.SourceCodeLine = 71;
                MakeString ( _184 , "{0} added to possible interfaces", _183 ) ; 
                __context__.SourceCodeLine = 71;
                _124 (  __context__ , "Luxul_FillPosition", _184) ; 
                __context__.SourceCodeLine = 71;
                _191 = (ushort) ( (_191 + 1) ) ; 
                __context__.SourceCodeLine = 71;
                } 
            
            } 
        
        __context__.SourceCodeLine = 71;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( _178[ 2 ] , (int)( 3 ) ) == "TX_") ) && Functions.TestForTrue ( Functions.Not( _194 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 71;
            _189 = (ushort) ( (Functions.Atoi( _178[ 1 ] ) - 10) ) ; 
            __context__.SourceCodeLine = 71;
            _183  .UpdateValue ( _178 [ 2 ]  ) ; 
            __context__.SourceCodeLine = 71;
            _184  .UpdateValue ( Functions.Remove ( "_" , _183 , 1)  ) ; 
            __context__.SourceCodeLine = 71;
            _184  .UpdateValue ( Functions.Remove ( "_gi" , _183 , 1)  ) ; 
            __context__.SourceCodeLine = 71;
            _109 [ _189 ]  .UpdateValue ( _183  ) ; 
            __context__.SourceCodeLine = 72;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)_191; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( _185  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_185  >= __FN_FORSTART_VAL__2) && (_185  <= __FN_FOREND_VAL__2) ) : ( (_185  <= __FN_FORSTART_VAL__2) && (_185  >= __FN_FOREND_VAL__2) ) ; _185  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 72;
                _193 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 72;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_181[ _185 ] == _109[ _189 ]))  ) ) 
                    { 
                    __context__.SourceCodeLine = 72;
                    _181 [ _185 ]  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 72;
                    _193 = (ushort) ( 65535 ) ; 
                    __context__.SourceCodeLine = 72;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 72;
                } 
            
            __context__.SourceCodeLine = 72;
            if ( Functions.TestForTrue  ( ( Functions.Not( _193 ))  ) ) 
                { 
                __context__.SourceCodeLine = 72;
                MakeString ( _184 , "Couldn't find {0} in possible interfaces.  iNumPossibleInterfaces = {1:d}", _109 [ _189 ] , (short)_191) ; 
                __context__.SourceCodeLine = 72;
                _124 (  __context__ , "Luxul_FillPosition", _184) ; 
                __context__.SourceCodeLine = 72;
                _192 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 72;
                break ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 70;
        } 
    
    __context__.SourceCodeLine = 72;
    _187 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 72;
    ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__3 = (ushort)_191; 
    int __FN_FORSTEP_VAL__3 = (int)1; 
    for ( _185  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (_185  >= __FN_FORSTART_VAL__3) && (_185  <= __FN_FOREND_VAL__3) ) : ( (_185  <= __FN_FORSTART_VAL__3) && (_185  >= __FN_FOREND_VAL__3) ) ; _185  += (ushort)__FN_FORSTEP_VAL__3) 
        { 
        __context__.SourceCodeLine = 72;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_181[ _185 ] == ""))  ) ) 
            {
            __context__.SourceCodeLine = 72;
            continue ; 
            }
        
        __context__.SourceCodeLine = 72;
        _108 [ _187 ]  .UpdateValue ( _181 [ _185 ]  ) ; 
        __context__.SourceCodeLine = 72;
        _187 = (ushort) ( (_187 + 1) ) ; 
        __context__.SourceCodeLine = 72;
        } 
    
    __context__.SourceCodeLine = 72;
    if ( Functions.TestForTrue  ( ( Functions.Not( _192 ))  ) ) 
        {
        __context__.SourceCodeLine = 72;
        _124 (  __context__ , "Luxul", "Invalid config") ; 
        }
    
    __context__.SourceCodeLine = 72;
    return (ushort)( _192) ; 
    
    }
    
private ushort _175 (  SplusExecutionContext __context__, CrestronString _177 , ushort _178 ) 
    { 
    CrestronString [] _179;
    CrestronString _180;
    CrestronString _181;
    _180  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    _181  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    _179  = new CrestronString[ 6 ];
    for( uint i = 0; i < 6; i++ )
        _179 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    CrestronString _182;
    _182  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    CrestronString _183;
    CrestronString _184;
    _183  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _184  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    ushort _185 = 0;
    ushort _186 = 0;
    ushort _187 = 0;
    ushort _188 = 0;
    ushort _189 = 0;
    
    ushort [] _190;
    _190  = new ushort[ 51 ];
    
    ushort _191 = 0;
    ushort _192 = 0;
    ushort _193 = 0;
    
    ushort _194 = 0;
    ushort _195 = 0;
    
    
    __context__.SourceCodeLine = 73;
    if ( Functions.TestForTrue  ( ( _178)  ) ) 
        {
        __context__.SourceCodeLine = 73;
        _174 (  __context__ , _177) ; 
        }
    
    __context__.SourceCodeLine = 73;
    _191 = (ushort) ( 65535 ) ; 
    __context__.SourceCodeLine = 73;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\r\n" , _177 , 1 ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 73;
        _180  .UpdateValue ( Functions.Remove ( "\r\n" , _177 , 1)  ) ; 
        __context__.SourceCodeLine = 73;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_180 == "") ) || Functions.TestForTrue ( Functions.BoolToInt (_180 == "\r\n") )) ))  ) ) 
            {
            __context__.SourceCodeLine = 73;
            continue ; 
            }
        
        __context__.SourceCodeLine = 73;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _180 , (int)( 4 ) ) == "VLAN"))  ) ) 
            { 
            __context__.SourceCodeLine = 73;
            _194 = (ushort) ( Functions.Find( "Name" , _180 , 1 ) ) ; 
            __context__.SourceCodeLine = 73;
            _195 = (ushort) ( Functions.Find( "Interface" , _180 , 1 ) ) ; 
            __context__.SourceCodeLine = 73;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_194 == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (_195 == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 73;
                _124 (  __context__ , "Luxul", "Couldn't find Name and Interface in VLAN table") ; 
                __context__.SourceCodeLine = 73;
                break ; 
                } 
            
            __context__.SourceCodeLine = 73;
            continue ; 
            } 
        
        __context__.SourceCodeLine = 73;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _180 , (int)( 4 ) ) == "----"))  ) ) 
            {
            __context__.SourceCodeLine = 73;
            continue ; 
            }
        
        __context__.SourceCodeLine = 73;
        _168 (  __context__ , _180, _179, (ushort)( _194 ), (ushort)( _195 )) ; 
        __context__.SourceCodeLine = 73;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _180 , (int)( 1 ) ) == " "))  ) ) 
            { 
            __context__.SourceCodeLine = 73;
            _179 [ 2 ]  .UpdateValue ( _182  ) ; 
            __context__.SourceCodeLine = 73;
            _193 = (ushort) ( 65535 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 74;
            _182  .UpdateValue ( _179 [ 2 ]  ) ; 
            __context__.SourceCodeLine = 74;
            _193 = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 74;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _179[ 2 ] , (int)( 4 ) ) == "JAP_"))  ) ) 
            {
            __context__.SourceCodeLine = 74;
            continue ; 
            }
        
        __context__.SourceCodeLine = 74;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( _179[ 2 ] , (int)( 3 ) ) == "TX_") ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( _179[ 3 ] , (int)( 3 ) ) == "Gi ") )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 74;
            _183  .UpdateValue ( Functions.Right ( _179 [ 3 ] ,  (int) ( (Functions.Length( _179[ 3 ] ) - 3) ) )  ) ; 
            __context__.SourceCodeLine = 74;
            _187 = (ushort) ( Functions.Atoi( Functions.Remove( "/" , _183 , 1 ) ) ) ; 
            __context__.SourceCodeLine = 74;
            _188 = (ushort) ( _171( __context__ , _183 , (ushort[])( _190 ) ) ) ; 
            __context__.SourceCodeLine = 74;
            if ( Functions.TestForTrue  ( ( Functions.Not( _193 ))  ) ) 
                {
                __context__.SourceCodeLine = 74;
                _186 = (ushort) ( (Functions.Atoi( _179[ 1 ] ) - 10) ) ; 
                }
            
            __context__.SourceCodeLine = 74;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_188; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _185  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_185  >= __FN_FORSTART_VAL__1) && (_185  <= __FN_FOREND_VAL__1) ) : ( (_185  <= __FN_FORSTART_VAL__1) && (_185  >= __FN_FOREND_VAL__1) ) ; _185  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 74;
                MakeString ( _183 , "{0:d}/{1:d}", (short)_187, (short)_190[ _185 ]) ; 
                __context__.SourceCodeLine = 74;
                _189 = (ushort) ( _172( __context__ , _183 ) ) ; 
                __context__.SourceCodeLine = 74;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_189 == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 74;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_173( __context__ , _183 ) == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 74;
                        MakeString ( _184 , "Couldn't find mapping for {0}", _183 ) ; 
                        __context__.SourceCodeLine = 74;
                        _124 (  __context__ , "Luxul", _184) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 74;
                    _116 [ _189 ]  .UpdateValue ( _109 [ _186 ]  ) ; 
                    __context__.SourceCodeLine = 74;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_178 == 65535))  ) ) 
                        {
                        __context__.SourceCodeLine = 74;
                        _115 [ _189 ]  .UpdateValue ( _109 [ _186 ]  ) ; 
                        }
                    
                    __context__.SourceCodeLine = 75;
                    MakeString ( _184 , "Output {0} = Input {1}", _183 , _116 [ _189 ] ) ; 
                    __context__.SourceCodeLine = 75;
                    _124 (  __context__ , "Luxul", _184) ; 
                    } 
                
                __context__.SourceCodeLine = 74;
                } 
            
            } 
        
        __context__.SourceCodeLine = 73;
        } 
    
    __context__.SourceCodeLine = 75;
    if ( Functions.TestForTrue  ( ( _191)  ) ) 
        { 
        __context__.SourceCodeLine = 75;
        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__2 = (ushort)_99; 
        int __FN_FORSTEP_VAL__2 = (int)1; 
        for ( _185  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_185  >= __FN_FORSTART_VAL__2) && (_185  <= __FN_FOREND_VAL__2) ) : ( (_185  <= __FN_FORSTART_VAL__2) && (_185  >= __FN_FOREND_VAL__2) ) ; _185  += (ushort)__FN_FORSTEP_VAL__2) 
            { 
            __context__.SourceCodeLine = 75;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_116[ _185 ] == ""))  ) ) 
                { 
                __context__.SourceCodeLine = 75;
                _191 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 75;
                MakeString ( _184 , "Output {0:d} is unassigned", (short)_185) ; 
                __context__.SourceCodeLine = 75;
                _124 (  __context__ , "Luxul", _184) ; 
                } 
            
            __context__.SourceCodeLine = 75;
            } 
        
        } 
    
    __context__.SourceCodeLine = 75;
    if ( Functions.TestForTrue  ( ( Functions.Not( _191 ))  ) ) 
        { 
        __context__.SourceCodeLine = 75;
        _124 (  __context__ , "Luxul", "Invalid config found") ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 75;
        ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__3 = (ushort)_99; 
        int __FN_FORSTEP_VAL__3 = (int)1; 
        for ( _185  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (_185  >= __FN_FORSTART_VAL__3) && (_185  <= __FN_FOREND_VAL__3) ) : ( (_185  <= __FN_FORSTART_VAL__3) && (_185  >= __FN_FOREND_VAL__3) ) ; _185  += (ushort)__FN_FORSTEP_VAL__3) 
            { 
            __context__.SourceCodeLine = 75;
            OUTPUTFB [ _185]  .Value = (ushort) ( _173( __context__ , _116[ _185 ] ) ) ; 
            __context__.SourceCodeLine = 75;
            MakeString ( _184 , "Output {0:d} on port {1} is set to input {2:d} on port {3}", (short)_185, _108 [ _185 ] , (short)_173( __context__ , _116[ _185 ] ), _116 [ _185 ] ) ; 
            __context__.SourceCodeLine = 75;
            _124 (  __context__ , "Luxul", _184) ; 
            __context__.SourceCodeLine = 75;
            } 
        
        } 
    
    __context__.SourceCodeLine = 75;
    return (ushort)( _191) ; 
    
    }
    
private void _176 (  SplusExecutionContext __context__, CrestronString _178 ) 
    { 
    
    __context__.SourceCodeLine = 75;
    if ( Functions.TestForTrue  ( ( _175( __context__ , _178 , (ushort)( 65535 ) ))  ) ) 
        { 
        __context__.SourceCodeLine = 76;
        REBOOTINGINPROGRESS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 76;
        ERRORMSG__DOLLAR__  .UpdateValue ( "NONE"  ) ; 
        __context__.SourceCodeLine = 76;
        _167 (  __context__  ) ; 
        __context__.SourceCodeLine = 76;
        _119 = (ushort) ( 65535 ) ; 
        __context__.SourceCodeLine = 76;
        _166 (  __context__  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 76;
        if ( Functions.TestForTrue  ( ( Functions.Not( _111 ))  ) ) 
            { 
            __context__.SourceCodeLine = 76;
            _111 = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 76;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 76;
            ERRORMSG__DOLLAR__  .UpdateValue ( "The module has detected an unusable configuration on the switch.\r\n\r\n" + "Restoring switch to default configuration.\r\n\r\nThis may take several minutes."  ) ; 
            __context__.SourceCodeLine = 76;
            _143 (  __context__ , "reload cold", (ushort)( 0 ), "% Cold reload in progress, please stand by.", (ushort)( 19 ), "Try Again Later") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 76;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 76;
            ERRORMSG__DOLLAR__  .UpdateValue ( "Bad Switch configuration\r\n\r\n Please run JAD CONFIG Again"  ) ; 
            __context__.SourceCodeLine = 76;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_3__" , 200 , __SPLS_TMPVAR__WAITLABEL_3___Callback ) ;
            } 
        
        } 
    
    
    }
    
public void __SPLS_TMPVAR__WAITLABEL_3___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 76;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 0 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private void _177 (  SplusExecutionContext __context__, CrestronString _179 ) 
    { 
    CrestronString _180;
    CrestronString _181;
    CrestronString _182;
    CrestronString _183;
    _180  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    _181  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _182  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    _183  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    ushort _184 = 0;
    ushort _185 = 0;
    
    ushort _186 = 0;
    
    
    __context__.SourceCodeLine = 77;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\r\n" , _179 , 1 ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 77;
        _180  .UpdateValue ( Functions.Remove ( "\r\n" , _179 , 1)  ) ; 
        __context__.SourceCodeLine = 77;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_180 == "") ) || Functions.TestForTrue ( Functions.BoolToInt (_180 == "\r\n") )) ))  ) ) 
            {
            __context__.SourceCodeLine = 77;
            continue ; 
            }
        
        __context__.SourceCodeLine = 77;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _180 , (int)( 9 ) ) == "Interface"))  ) ) 
            { 
            __context__.SourceCodeLine = 77;
            _186 = (ushort) ( Functions.Find( "Port Status" , _180 , 1 ) ) ; 
            __context__.SourceCodeLine = 77;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_186 == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 77;
                _124 (  __context__ , "Luxul", "Couldn't find Port Status in PoE table") ; 
                __context__.SourceCodeLine = 77;
                break ; 
                } 
            
            __context__.SourceCodeLine = 77;
            continue ; 
            } 
        
        __context__.SourceCodeLine = 77;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _180 , (int)( 4 ) ) == "----"))  ) ) 
            {
            __context__.SourceCodeLine = 77;
            continue ; 
            }
        
        __context__.SourceCodeLine = 77;
        _181  .UpdateValue ( Functions.Left ( _180 ,  (int) ( _186 ) )  ) ; 
        __context__.SourceCodeLine = 77;
        _184 = (ushort) ( Functions.Atoi( Functions.Remove( "/" , _181 , 1 ) ) ) ; 
        __context__.SourceCodeLine = 77;
        _185 = (ushort) ( Functions.Atoi( Functions.Left( _181 , (int)( 3 ) ) ) ) ; 
        __context__.SourceCodeLine = 77;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_184 == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (_185 == 0) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 77;
            continue ; 
            }
        
        __context__.SourceCodeLine = 78;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( _180 , (int)( _186 ) , (int)( 12 ) ) == "PoE disabled") ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( _180 , (int)( _186 ) , (int)( 13 ) ) == "No PoE client") )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 78;
            _110 [ _184 , _185] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 78;
            _182  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 78;
            _110 [ _184 , _185] = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 78;
            _182  .UpdateValue ( "ON"  ) ; 
            } 
        
        __context__.SourceCodeLine = 78;
        MakeString ( _183 , "PoE for port {0:d}/{1:d}:{2}", (short)_184, (short)_185, _182 ) ; 
        __context__.SourceCodeLine = 78;
        _124 (  __context__ , "Luxul", _183) ; 
        __context__.SourceCodeLine = 77;
        } 
    
    
    }
    
private void _178 (  SplusExecutionContext __context__, CrestronString _180 ) 
    { 
    
    __context__.SourceCodeLine = 78;
    if ( Functions.TestForTrue  ( ( _175( __context__ , _180 , (ushort)( 0 ) ))  ) ) 
        { 
        __context__.SourceCodeLine = 78;
        if ( Functions.TestForTrue  ( ( _112)  ) ) 
            { 
            __context__.SourceCodeLine = 78;
            _112 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 78;
            _153 (  __context__  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 78;
            if ( Functions.TestForTrue  ( ( _121)  ) ) 
                { 
                __context__.SourceCodeLine = 78;
                _121 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 78;
                _166 (  __context__  ) ; 
                } 
            
            }
        
        } 
    
    else 
        {
        __context__.SourceCodeLine = 78;
        if ( Functions.TestForTrue  ( ( _121)  ) ) 
            { 
            __context__.SourceCodeLine = 78;
            _111 = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 78;
            _119 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 78;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 78;
            ERRORMSG__DOLLAR__  .UpdateValue ( "The module has detected an unusable configuration on the switch.\r\n\r\n" + "Restoring switch to default configuration.\r\n\r\nThis may take several minutes."  ) ; 
            __context__.SourceCodeLine = 79;
            _143 (  __context__ , "reload cold", (ushort)( 0 ), "% Cold reload in progress, please stand by.", (ushort)( 19 ), "Try Again Later") ; 
            } 
        
        }
    
    
    }
    
private void _179 (  SplusExecutionContext __context__, ushort _181 , CrestronString _182 ) 
    { 
    
    __context__.SourceCodeLine = 79;
    _124 (  __context__ , "MsgActionSwitch - ", Functions.ItoA( (int)( _181 ) )) ; 
    __context__.SourceCodeLine = 79;
    
        {
        int __SPLS_TMPVAR__SWTCH_7__ = ((int)_181);
        
            { 
            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 1) ) ) ) 
                { 
                __context__.SourceCodeLine = 79;
                _140 (  __context__ , _182) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 2) ) ) ) 
                { 
                __context__.SourceCodeLine = 79;
                _139 (  __context__ , _182) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 4) ) ) ) 
                { 
                __context__.SourceCodeLine = 79;
                _138 (  __context__ , _182) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 10) ) ) ) 
                { 
                __context__.SourceCodeLine = 79;
                _176 (  __context__ , _182) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 11) ) ) ) 
                { 
                __context__.SourceCodeLine = 79;
                _178 (  __context__ , _182) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 12) ) ) ) 
                { 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 13) ) ) ) 
                { 
                __context__.SourceCodeLine = 79;
                _177 (  __context__ , _182) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 14) ) ) ) 
                { 
                __context__.SourceCodeLine = 79;
                _165 (  __context__  ) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 18) ) ) ) 
                { 
                __context__.SourceCodeLine = 79;
                CreateWait ( "__SPLS_TMPVAR__WAITLABEL_4__" , 2000 , __SPLS_TMPVAR__WAITLABEL_4___Callback ) ;
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 19) ) ) ) 
                { 
                __context__.SourceCodeLine = 79;
                _159 (  __context__  ) ; 
                } 
            
            } 
            
        }
        
    
    
    }
    
public void __SPLS_TMPVAR__WAITLABEL_4___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 79;
            _133 (  __context__  ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private void _180 (  SplusExecutionContext __context__ ) 
    { 
    ushort _182 = 0;
    ushort _183 = 0;
    
    CrestronString _184;
    _184  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    
    __context__.SourceCodeLine = 80;
    _182 = (ushort) ( Functions.Find( "\u0027" , _79._72 , 1 ) ) ; 
    __context__.SourceCodeLine = 80;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _182 > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 80;
        _184  .UpdateValue ( Functions.Mid ( _79 . _72 ,  (int) ( 1 ) ,  (int) ( _182 ) )  ) ; 
        __context__.SourceCodeLine = 80;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "#" , _79._72 , 1 ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 80;
            _79 . _73 = (ushort) ( (Functions.Length( _79._72 ) - _182) ) ; 
            __context__.SourceCodeLine = 80;
            _79 . _72  .UpdateValue ( Functions.Right ( _79 . _72 ,  (int) ( _79._73 ) )  ) ; 
            } 
        
        } 
    
    
    }
    
private void _181 (  SplusExecutionContext __context__ ) 
    { 
    CrestronString _183;
    _183  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    
    _87 _184;
    _184  = new _87( this, true );
    _184 .PopulateCustomAttributeList( false );
    
    
    __context__.SourceCodeLine = 80;
    Functions.Pulse ( 10, __TRIGGER_START_HEARTBEAT_OUT ) ; 
    __context__.SourceCodeLine = 80;
    if ( Functions.TestForTrue  ( ( _49( __context__ , ref _96 ))  ) ) 
        { 
        __context__.SourceCodeLine = 80;
        _95 . _88  .UpdateValue ( "NULL STRING"  ) ; 
        __context__.SourceCodeLine = 80;
        if ( Functions.TestForTrue  ( ( _86._85)  ) ) 
            {
            __context__.SourceCodeLine = 80;
            _118 = (ushort) ( _163( __context__ , (ushort)( _118 ) ) ) ; 
            }
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 80;
        _129 (  __context__ ,   ref  _184 ) ; 
        __context__.SourceCodeLine = 80;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_184._88 == "NULL STRING"))  ) ) 
            {
            __context__.SourceCodeLine = 80;
            Functions.Pulse ( 5, __TRIGGER_SEND_NEXT_CMD_OUT ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 80;
            _137 (  __context__ , _184) ; 
            }
        
        } 
    
    
    }
    
private ushort _182 (  SplusExecutionContext __context__ ) 
    { 
    ushort _184 = 0;
    ushort _185 = 0;
    ushort _186 = 0;
    ushort _187 = 0;
    
    CrestronString _5;
    _5  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    ushort _188 = 0;
    
    CrestronString _189;
    CrestronString _190;
    _189  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10000, this );
    _190  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10000, this );
    
    ushort _191 = 0;
    
    ushort _192 = 0;
    
    
    __context__.SourceCodeLine = 81;
    _124 (  __context__ , "fnMessageHandler_onCommRx g_debugRXCommsCnt ", Functions.ItoA( (int)( _123 ) )) ; 
    __context__.SourceCodeLine = 81;
    _123 = (ushort) ( (_123 + 1) ) ; 
    __context__.SourceCodeLine = 81;
    _191 = (ushort) ( _100 ) ; 
    __context__.SourceCodeLine = 81;
    _180 (  __context__  ) ; 
    __context__.SourceCodeLine = 81;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "**** IDLE TIMEOUT ***\r\n\r\n\r\n" , _79._72 , 1 ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 81;
        SWITCH_CLIENT .  SocketRxBuf  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 81;
        _184 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 81;
        _133 (  __context__  ) ; 
        __context__.SourceCodeLine = 81;
        _134 (  __context__  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 81;
        _5  .UpdateValue ( _95 . _89  ) ; 
        __context__.SourceCodeLine = 81;
        _124 (  __context__ , "fnMessageHandler_onCommRx ok pattern = ", _5) ; 
        __context__.SourceCodeLine = 81;
        _124 (  __context__ , "fnMessageHandler_onCommRx g_MessageHandlerComms.inputString ", _79._72) ; 
        __context__.SourceCodeLine = 81;
        _124 (  __context__ , "fnMessageHandler_onCommRx g_MessageHandlerComms.inputLength ", Functions.ItoA( (int)( _79._73 ) )) ; 
        __context__.SourceCodeLine = 81;
        _184 = (ushort) ( Functions.Find( _5 , _79._72 ) ) ; 
        __context__.SourceCodeLine = 82;
        _124 (  __context__ , "fnMessageHandler_onCommRx pos ", Functions.ItoA( (int)( _184 ) )) ; 
        __context__.SourceCodeLine = 82;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _184 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 82;
            _188 = (ushort) ( _95._90 ) ; 
            __context__.SourceCodeLine = 82;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_5__" , 10 , __SPLS_TMPVAR__WAITLABEL_5___Callback ) ;
            } 
        
        else 
            {
            __context__.SourceCodeLine = 82;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( _95._91 ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 82;
                _5  .UpdateValue ( _95 . _91  ) ; 
                __context__.SourceCodeLine = 82;
                _184 = (ushort) ( Functions.Find( _5 , _79._72 ) ) ; 
                __context__.SourceCodeLine = 82;
                _124 (  __context__ , "fnMessageHandler_onCommRx fail pos ", Functions.ItoA( (int)( _184 ) )) ; 
                __context__.SourceCodeLine = 82;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _184 > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 82;
                    _188 = (ushort) ( _95._92 ) ; 
                    __context__.SourceCodeLine = 82;
                    if ( Functions.TestForTrue  ( ( _122)  ) ) 
                        { 
                        __context__.SourceCodeLine = 82;
                        _122 = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 82;
                        CancelWait ( "WAIT_FOR_RX_SEND" ) ; 
                        } 
                    
                    } 
                
                } 
            
            }
        
        __context__.SourceCodeLine = 82;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _184 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 82;
            _186 = (ushort) ( Functions.Find( _95._88 , _79._72 ) ) ; 
            __context__.SourceCodeLine = 82;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _186 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 82;
                _189  .UpdateValue ( Functions.Mid ( _79 . _72 ,  (int) ( (_186 + Functions.Length( _95._88 )) ) ,  (int) ( (Functions.Length( _79._72 ) - ((_186 + Functions.Length( _95._88 )) - 1)) ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 82;
            _184 = (ushort) ( ((_184 + Functions.Length( _5 )) - 1) ) ; 
            __context__.SourceCodeLine = 82;
            _190  .UpdateValue ( Functions.Remove ( _184, _79 . _72 )  ) ; 
            __context__.SourceCodeLine = 83;
            _79 . _73 = (ushort) ( (_79._73 - _184) ) ; 
            __context__.SourceCodeLine = 83;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _188 > 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 83;
                _179 (  __context__ , (ushort)( _188 ), _189) ; 
                }
            
            __context__.SourceCodeLine = 83;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_191 == _100))  ) ) 
                {
                __context__.SourceCodeLine = 83;
                Functions.Pulse ( 1, __TRIGGER_SEND_NEXT_CMD_OUT ) ; 
                }
            
            } 
        
        } 
    
    __context__.SourceCodeLine = 83;
    return (ushort)( _184) ; 
    
    }
    
public void __SPLS_TMPVAR__WAITLABEL_5___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 82;
            if ( Functions.TestForTrue  ( ( _122)  ) ) 
                { 
                __context__.SourceCodeLine = 82;
                _122 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 82;
                CancelWait ( "WAIT_FOR_RX_SEND" ) ; 
                } 
            
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private ushort _183 (  SplusExecutionContext __context__ ) 
    { 
    ushort _185 = 0;
    
    
    __context__.SourceCodeLine = 83;
    _185 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 83;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.GetC( _102 ) != 65535))  ) ) 
        {
        __context__.SourceCodeLine = 83;
        _185 = (ushort) ( 65535 ) ; 
        __context__.SourceCodeLine = 83;
        }
    
    __context__.SourceCodeLine = 83;
    return (ushort)( _185) ; 
    
    }
    
private void _184 (  SplusExecutionContext __context__, CrestronString _88 ) 
    { 
    ushort _186 = 0;
    ushort _187 = 0;
    ushort _188 = 0;
    
    CrestronString _189;
    CrestronString _190;
    CrestronString _191;
    CrestronString _192;
    CrestronString _193;
    CrestronString ACTION;
    CrestronString _76;
    CrestronString STACKSWITCHNUMBER;
    _189  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    _190  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    _191  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    _192  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _193  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    ACTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    _76  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    STACKSWITCHNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    
    
    __context__.SourceCodeLine = 83;
    _124 (  __context__ , "ExtractPOECommand cmd", _88) ; 
    __context__.SourceCodeLine = 83;
    _189  .UpdateValue ( Functions.Remove ( " " , _88 , 1)  ) ; 
    __context__.SourceCodeLine = 83;
    _189  .UpdateValue ( Functions.Left ( _189 ,  (int) ( (Functions.Length( _189 ) - 1) ) )  ) ; 
    __context__.SourceCodeLine = 83;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_189 == "POE"))  ) ) 
        { 
        __context__.SourceCodeLine = 83;
        _186 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 83;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( ";" , _88 , 1 ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 83;
            _192  .UpdateValue ( Functions.Remove ( ";" , _88 , 1)  ) ; 
            __context__.SourceCodeLine = 84;
            _192  .UpdateValue ( Functions.Left ( _192 ,  (int) ( (Functions.Length( _192 ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 84;
            _193  .UpdateValue ( Functions.Remove ( "=" , _192 , 1)  ) ; 
            __context__.SourceCodeLine = 84;
            _193  .UpdateValue ( Functions.Left ( _193 ,  (int) ( (Functions.Length( _193 ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 84;
            ACTION  .UpdateValue ( _192  ) ; 
            __context__.SourceCodeLine = 84;
            STACKSWITCHNUMBER  .UpdateValue ( Functions.Remove ( "," , _193 , 1)  ) ; 
            __context__.SourceCodeLine = 84;
            STACKSWITCHNUMBER  .UpdateValue ( Functions.Left ( STACKSWITCHNUMBER ,  (int) ( (Functions.Length( STACKSWITCHNUMBER ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 84;
            _76  .UpdateValue ( _193  ) ; 
            __context__.SourceCodeLine = 84;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (STACKSWITCHNUMBER != "") ) && Functions.TestForTrue ( Functions.BoolToInt (_76 != "") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 84;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_8__ = ((int)Functions.Atoi( STACKSWITCHNUMBER ));
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 1) ) ) ) 
                            {
                            __context__.SourceCodeLine = 84;
                            _188 = (ushort) ( (500 + Functions.Atoi( _76 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 2) ) ) ) 
                            {
                            __context__.SourceCodeLine = 84;
                            _188 = (ushort) ( (610 + Functions.Atoi( _76 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 3) ) ) ) 
                            {
                            __context__.SourceCodeLine = 84;
                            _188 = (ushort) ( (720 + Functions.Atoi( _76 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 4) ) ) ) 
                            {
                            __context__.SourceCodeLine = 84;
                            _188 = (ushort) ( (830 + Functions.Atoi( _76 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 5) ) ) ) 
                            {
                            __context__.SourceCodeLine = 84;
                            _188 = (ushort) ( (940 + Functions.Atoi( _76 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 6) ) ) ) 
                            {
                            __context__.SourceCodeLine = 84;
                            _188 = (ushort) ( (1050 + Functions.Atoi( _76 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 7) ) ) ) 
                            {
                            __context__.SourceCodeLine = 84;
                            _188 = (ushort) ( (1160 + Functions.Atoi( _76 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 8) ) ) ) 
                            {
                            __context__.SourceCodeLine = 84;
                            _188 = (ushort) ( (1270 + Functions.Atoi( _76 )) ) ; 
                            }
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 84;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ACTION == "ON"))  ) ) 
                    { 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 85;
                    _188 = (ushort) ( (_188 + 52) ) ; 
                    } 
                
                __context__.SourceCodeLine = 85;
                _124 (  __context__ , "ExtractPOECommand StackSwitchNumber", STACKSWITCHNUMBER) ; 
                __context__.SourceCodeLine = 85;
                _124 (  __context__ , "ExtractPOECommand index", Functions.ItoA( (int)( _188 ) )) ; 
                __context__.SourceCodeLine = 85;
                _124 (  __context__ , "ExtractPOECommand Action", ACTION) ; 
                __context__.SourceCodeLine = 85;
                _115 [ _188 ]  .UpdateValue ( "1"  ) ; 
                __context__.SourceCodeLine = 85;
                _164 (  __context__  ) ; 
                } 
            
            __context__.SourceCodeLine = 83;
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 85;
        _124 (  __context__ , "ExtractPOECommand", "UNKNOWN COMMAND") ; 
        } 
    
    
    }
    
private void _185 (  SplusExecutionContext __context__, CrestronString _88 ) 
    { 
    ushort _187 = 0;
    ushort _188 = 0;
    ushort _189 = 0;
    ushort _190 = 0;
    ushort _191 = 0;
    
    CrestronString _192;
    CrestronString _193;
    CrestronString _194;
    CrestronString _195;
    CrestronString _196;
    _192  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _193  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _194  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    _195  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    _196  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    
    __context__.SourceCodeLine = 85;
    _187 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 85;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt (_187 != 0))  ) ) 
        { 
        __context__.SourceCodeLine = 85;
        _187 = (ushort) ( Functions.Find( ";" , _88 , 1 ) ) ; 
        __context__.SourceCodeLine = 85;
        _192  .UpdateValue ( Functions.Remove ( ";" , _88 , 1)  ) ; 
        __context__.SourceCodeLine = 85;
        _192  .UpdateValue ( Functions.Left ( _192 ,  (int) ( (Functions.Length( _192 ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 85;
        _193  .UpdateValue ( Functions.Remove ( "SW " , _192 , 1)  ) ; 
        __context__.SourceCodeLine = 85;
        _193  .UpdateValue ( Functions.Remove ( "=" , _192 , 1)  ) ; 
        __context__.SourceCodeLine = 86;
        _193  .UpdateValue ( Functions.Left ( _193 ,  (int) ( (Functions.Length( _193 ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 86;
        _194  .UpdateValue ( _192  ) ; 
        __context__.SourceCodeLine = 86;
        _191 = (ushort) ( Functions.Atoi( _194 ) ) ; 
        __context__.SourceCodeLine = 86;
        _188 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 86;
        do 
            { 
            __context__.SourceCodeLine = 86;
            _189 = (ushort) ( Functions.Find( "," , _193 , 1 ) ) ; 
            __context__.SourceCodeLine = 86;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _189 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 86;
                _196  .UpdateValue ( Functions.Remove ( "," , _193 , 1)  ) ; 
                __context__.SourceCodeLine = 86;
                _196  .UpdateValue ( Functions.Left ( _196 ,  (int) ( (Functions.Length( _196 ) - 1) ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 86;
                _196  .UpdateValue ( _193  ) ; 
                } 
            
            __context__.SourceCodeLine = 86;
            _190 = (ushort) ( Functions.Atoi( _196 ) ) ; 
            __context__.SourceCodeLine = 86;
            _124 (  __context__ , "ExtractInputAndOutputForSwitch iOutputPort;", Functions.ItoA( (int)( _190 ) )) ; 
            __context__.SourceCodeLine = 86;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _190 <= _99 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _190 > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _191 <= _98 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _191 > 0 ) )) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 86;
                _116 [ _190 ]  .UpdateValue ( "0"  ) ; 
                __context__.SourceCodeLine = 86;
                _115 [ _190 ]  .UpdateValue ( _194  ) ; 
                } 
            
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( _189 < 1 )) )); 
        __context__.SourceCodeLine = 86;
        _164 (  __context__  ) ; 
        __context__.SourceCodeLine = 85;
        } 
    
    
    }
    
private void _186 (  SplusExecutionContext __context__, ushort _188 , ushort _189 ) 
    { 
    
    __context__.SourceCodeLine = 86;
    _124 (  __context__ , "fnLuxulSwitch_handleSetInput input", Functions.ItoA( (int)( _188 ) )) ; 
    __context__.SourceCodeLine = 86;
    _124 (  __context__ , "fnLuxulSwitch_handleSetInput ioutput", Functions.ItoA( (int)( _189 ) )) ; 
    __context__.SourceCodeLine = 87;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _189 <= _99 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _189 > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _188 <= _98 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _188 > 0 ) )) ) )) ))  ) ) 
        { 
        __context__.SourceCodeLine = 87;
        _116 [ _189 ]  .UpdateValue ( "0"  ) ; 
        __context__.SourceCodeLine = 87;
        _115 [ _189 ]  .UpdateValue ( Functions.ItoA (  (int) ( _188 ) )  ) ; 
        __context__.SourceCodeLine = 87;
        _164 (  __context__  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 87;
        _124 (  __context__ , "fnLuxulSwitch_handleSetInput ", "Cant Process this in demo mode") ; 
        } 
    
    
    }
    
private void _187 (  SplusExecutionContext __context__, CrestronString _189 ) 
    { 
    ushort _190 = 0;
    
    
    __context__.SourceCodeLine = 87;
    _190 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 87;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _190 < Functions.Length( _189 ) ))  ) ) 
        { 
        __context__.SourceCodeLine = 87;
        Print( "{0}", Functions.Mid ( _189 ,  (int) ( _190 ) ,  (int) ( 100 ) ) ) ; 
        __context__.SourceCodeLine = 87;
        _190 = (ushort) ( (_190 + 100) ) ; 
        __context__.SourceCodeLine = 87;
        } 
    
    
    }
    
object START_MODULE_OnPush_0 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 87;
        _162 (  __context__  ) ; 
        __context__.SourceCodeLine = 87;
        _161 (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REFRESH_STATUS_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 87;
        if ( Functions.TestForTrue  ( ( _86._85)  ) ) 
            { 
            __context__.SourceCodeLine = 87;
            _115 [ 1382 ]  .UpdateValue ( "1"  ) ; 
            __context__.SourceCodeLine = 87;
            _164 (  __context__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 87;
            _124 (  __context__ , "refresh_status", "g_LuxulSwitch.readyForCommands = false") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEND_SAVE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 87;
        if ( Functions.TestForTrue  ( ( _86._85)  ) ) 
            { 
            __context__.SourceCodeLine = 87;
            _115 [ 1381 ]  .UpdateValue ( "1"  ) ; 
            __context__.SourceCodeLine = 87;
            _164 (  __context__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 88;
            _124 (  __context__ , "send_save", "g_LuxulSwitch.readyForCommands = false") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POE_CMD_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 88;
        _184 (  __context__ , POE_CMD) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FAVOUTITE_CMD_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 88;
        _185 (  __context__ , FAVOUTITE_CMD) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEBUGENABLE_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 88;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUGENABLE == "enable debug"))  ) ) 
            {
            __context__.SourceCodeLine = 88;
            _101 = (ushort) ( 65535 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 88;
            _101 = (ushort) ( 0 ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CRESTRON_MAC_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 88;
        _107  .UpdateValue ( _107 + CRESTRON_MAC  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OUTPUT_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort OUTPUTPORT = 0;
        ushort INPUTPORT = 0;
        
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 88;
        OUTPUTPORT = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 88;
        INPUTPORT = (ushort) ( OUTPUT[ OUTPUTPORT ] .UshortValue ) ; 
        __context__.SourceCodeLine = 88;
        _124 (  __context__ , "Output Switching", "") ; 
        __context__.SourceCodeLine = 88;
        _186 (  __context__ , (ushort)( INPUTPORT ), (ushort)( OUTPUTPORT )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_CLIENT_OnSocketConnect_8 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 88;
        _95 . _89  .UpdateValue ( "Username:"  ) ; 
        __context__.SourceCodeLine = 88;
        _95 . _90 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 88;
        _95 . _91  .UpdateValue ( "#"  ) ; 
        __context__.SourceCodeLine = 88;
        _95 . _92 = (ushort) ( 14 ) ; 
        __context__.SourceCodeLine = 89;
        _104  .UpdateValue ( "Client Connect Event. Connected to: " + P_SWITCHIP + ":" + P_SWITCHPORT  ) ; 
        __context__.SourceCodeLine = 89;
        _124 (  __context__ , "socket", _104) ; 
        __context__.SourceCodeLine = 89;
        _142 (  __context__ , (ushort)( 1 )) ; 
        __context__.SourceCodeLine = 89;
        _57 (  __context__ ,   ref  _96 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object SWITCH_CLIENT_OnSocketDisconnect_9 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 89;
        _124 (  __context__ , "socket", "Client Disconnect Event") ; 
        __context__.SourceCodeLine = 89;
        _142 (  __context__ , (ushort)( 0 )) ; 
        __context__.SourceCodeLine = 89;
        _113 = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object SWITCH_CLIENT_OnSocketStatus_10 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        short STATUS = 0;
        
        
        __context__.SourceCodeLine = 89;
        STATUS = (short) ( __SocketInfo__.SocketStatus ) ; 
        __context__.SourceCodeLine = 89;
        _124 (  __context__ , "The SocketGetStatus returns:", Functions.ItoA( (int)( STATUS ) )) ; 
        __context__.SourceCodeLine = 89;
        _124 (  __context__ , "The MyClient.SocketStatus returns:", Functions.ItoA( (int)( SWITCH_CLIENT.SocketStatus ) )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

private void _188 (  SplusExecutionContext __context__ ) 
    { 
    ushort _190 = 0;
    
    
    __context__.SourceCodeLine = 89;
    if ( Functions.TestForTrue  ( ( _97)  ) ) 
        { 
        __context__.SourceCodeLine = 89;
        Functions.Pulse ( 10, __SOCKET_RECEIVE_BUSY ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 89;
        _97 = (ushort) ( 65535 ) ; 
        __context__.SourceCodeLine = 90;
        _190 = (ushort) ( Functions.Length( SWITCH_CLIENT.SocketRxBuf ) ) ; 
        __context__.SourceCodeLine = 90;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _190 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 90;
            _79 . _72  .UpdateValue ( _79 . _72 + Functions.Remove ( _190, SWITCH_CLIENT .  SocketRxBuf )  ) ; 
            __context__.SourceCodeLine = 90;
            _79 . _73 = (ushort) ( (_79._73 + _190) ) ; 
            __context__.SourceCodeLine = 90;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _182( __context__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 90;
                } 
            
            } 
        
        __context__.SourceCodeLine = 90;
        _97 = (ushort) ( 0 ) ; 
        } 
    
    
    }
    
object __TRIGGER_PROCESS_SOCKET_RECEIVE_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 90;
        _188 (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object __TRIGGER_SEND_NEXT_CMD_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 90;
        _181 (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object __TRIGGER_HEARTBEAT_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 90;
        if ( Functions.TestForTrue  ( ( Functions.Not( _86._85 ))  ) ) 
            {
            __context__.SourceCodeLine = 90;
            _148 (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_CLIENT_OnSocketReceive_14 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 90;
        _188 (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort _190 = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 90;
        _97 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 90;
        _107  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 90;
        _106 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 90;
        _58 (  __context__ ,   ref  _96 , (ushort)( 1000 )) ; 
        __context__.SourceCodeLine = 90;
        VERSION__DOLLAR__  .UpdateValue ( "V1_03"  ) ; 
        __context__.SourceCodeLine = 90;
        ERRORMSG__DOLLAR__  .UpdateValue ( "NONE"  ) ; 
        __context__.SourceCodeLine = 90;
        _100 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 90;
        _112 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 90;
        _101 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 90;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)1500; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( _190  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_190  >= __FN_FORSTART_VAL__1) && (_190  <= __FN_FOREND_VAL__1) ) : ( (_190  <= __FN_FORSTART_VAL__1) && (_190  >= __FN_FOREND_VAL__1) ) ; _190  += (ushort)__FN_FORSTEP_VAL__1) 
            {
            __context__.SourceCodeLine = 90;
            _115 [ _190 ]  .UpdateValue ( "0"  ) ; 
            __context__.SourceCodeLine = 90;
            }
        
        __context__.SourceCodeLine = 90;
        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__2 = (ushort)1500; 
        int __FN_FORSTEP_VAL__2 = (int)1; 
        for ( _190  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_190  >= __FN_FORSTART_VAL__2) && (_190  <= __FN_FOREND_VAL__2) ) : ( (_190  <= __FN_FORSTART_VAL__2) && (_190  >= __FN_FOREND_VAL__2) ) ; _190  += (ushort)__FN_FORSTEP_VAL__2) 
            {
            __context__.SourceCodeLine = 90;
            _116 [ _190 ]  .UpdateValue ( "0"  ) ; 
            __context__.SourceCodeLine = 90;
            }
        
        __context__.SourceCodeLine = 91;
        _120 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 91;
        _113 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 91;
        _117 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 91;
        _118 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 91;
        _119 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 91;
        _123 = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _103  = new ushort[ 81 ];
    _110  = new ushort[ 9,53 ];
    _102  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    _104  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    _107  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    _108  = new CrestronString[ 405 ];
    for( uint i = 0; i < 405; i++ )
        _108 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    _109  = new CrestronString[ 405 ];
    for( uint i = 0; i < 405; i++ )
        _109 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    _115  = new CrestronString[ 1501 ];
    for( uint i = 0; i < 1501; i++ )
        _115 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    _116  = new CrestronString[ 1501 ];
    for( uint i = 0; i < 1501; i++ )
        _116 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    SWITCH_CLIENT  = new SplusTcpClient ( 64000, this );
    _79  = new _71( this, true );
    _79 .PopulateCustomAttributeList( false );
    _86  = new _80( this, true );
    _86 .PopulateCustomAttributeList( false );
    _95  = new _87( this, true );
    _95 .PopulateCustomAttributeList( false );
    _96  = new _41( this, true );
    _96 .PopulateCustomAttributeList( false );
    _94  = new _87[ 1001 ];
    for( uint i = 0; i < 1001; i++ )
    {
        _94 [i] = new _87( this, true );
        _94 [i].PopulateCustomAttributeList( false );
        
    }
    
    __TRIGGER_SEND_NEXT_CMD = new Crestron.Logos.SplusObjects.DigitalInput( __TRIGGER_SEND_NEXT_CMD__DigitalInput__, this );
    m_DigitalInputList.Add( __TRIGGER_SEND_NEXT_CMD__DigitalInput__, __TRIGGER_SEND_NEXT_CMD );
    
    __TRIGGER_HEARTBEAT = new Crestron.Logos.SplusObjects.DigitalInput( __TRIGGER_HEARTBEAT__DigitalInput__, this );
    m_DigitalInputList.Add( __TRIGGER_HEARTBEAT__DigitalInput__, __TRIGGER_HEARTBEAT );
    
    __TRIGGER_PROCESS_SOCKET_RECEIVE = new Crestron.Logos.SplusObjects.DigitalInput( __TRIGGER_PROCESS_SOCKET_RECEIVE__DigitalInput__, this );
    m_DigitalInputList.Add( __TRIGGER_PROCESS_SOCKET_RECEIVE__DigitalInput__, __TRIGGER_PROCESS_SOCKET_RECEIVE );
    
    REFRESH_STATUS = new Crestron.Logos.SplusObjects.DigitalInput( REFRESH_STATUS__DigitalInput__, this );
    m_DigitalInputList.Add( REFRESH_STATUS__DigitalInput__, REFRESH_STATUS );
    
    START_MODULE = new Crestron.Logos.SplusObjects.DigitalInput( START_MODULE__DigitalInput__, this );
    m_DigitalInputList.Add( START_MODULE__DigitalInput__, START_MODULE );
    
    SEND_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( SEND_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( SEND_SAVE__DigitalInput__, SEND_SAVE );
    
    __TRIGGER_SEND_NEXT_CMD_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( __TRIGGER_SEND_NEXT_CMD_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( __TRIGGER_SEND_NEXT_CMD_OUT__DigitalOutput__, __TRIGGER_SEND_NEXT_CMD_OUT );
    
    __TRIGGER_START_HEARTBEAT_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( __TRIGGER_START_HEARTBEAT_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( __TRIGGER_START_HEARTBEAT_OUT__DigitalOutput__, __TRIGGER_START_HEARTBEAT_OUT );
    
    __SOCKET_RECEIVE_BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( __SOCKET_RECEIVE_BUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( __SOCKET_RECEIVE_BUSY__DigitalOutput__, __SOCKET_RECEIVE_BUSY );
    
    REBOOTINGINPROGRESS = new Crestron.Logos.SplusObjects.DigitalOutput( REBOOTINGINPROGRESS__DigitalOutput__, this );
    m_DigitalOutputList.Add( REBOOTINGINPROGRESS__DigitalOutput__, REBOOTINGINPROGRESS );
    
    OUTPUT = new InOutArray<AnalogInput>( 404, this );
    for( uint i = 0; i < 404; i++ )
    {
        OUTPUT[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( OUTPUT__AnalogSerialInput__ + i, OUTPUT__AnalogSerialInput__, this );
        m_AnalogInputList.Add( OUTPUT__AnalogSerialInput__ + i, OUTPUT[i+1] );
    }
    
    NUMOFOUTPUTS = new Crestron.Logos.SplusObjects.AnalogOutput( NUMOFOUTPUTS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NUMOFOUTPUTS__AnalogSerialOutput__, NUMOFOUTPUTS );
    
    NUMOFINPUTS = new Crestron.Logos.SplusObjects.AnalogOutput( NUMOFINPUTS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NUMOFINPUTS__AnalogSerialOutput__, NUMOFINPUTS );
    
    OUTPUTFB = new InOutArray<AnalogOutput>( 404, this );
    for( uint i = 0; i < 404; i++ )
    {
        OUTPUTFB[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( OUTPUTFB__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( OUTPUTFB__AnalogSerialOutput__ + i, OUTPUTFB[i+1] );
    }
    
    FAVOUTITE_CMD = new Crestron.Logos.SplusObjects.StringInput( FAVOUTITE_CMD__AnalogSerialInput__, 1000, this );
    m_StringInputList.Add( FAVOUTITE_CMD__AnalogSerialInput__, FAVOUTITE_CMD );
    
    POE_CMD = new Crestron.Logos.SplusObjects.StringInput( POE_CMD__AnalogSerialInput__, 1000, this );
    m_StringInputList.Add( POE_CMD__AnalogSerialInput__, POE_CMD );
    
    DEBUGENABLE = new Crestron.Logos.SplusObjects.StringInput( DEBUGENABLE__AnalogSerialInput__, 50, this );
    m_StringInputList.Add( DEBUGENABLE__AnalogSerialInput__, DEBUGENABLE );
    
    CRESTRON_MAC = new Crestron.Logos.SplusObjects.StringInput( CRESTRON_MAC__AnalogSerialInput__, 200, this );
    m_StringInputList.Add( CRESTRON_MAC__AnalogSerialInput__, CRESTRON_MAC );
    
    OPERATIONFB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( OPERATIONFB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( OPERATIONFB__DOLLAR____AnalogSerialOutput__, OPERATIONFB__DOLLAR__ );
    
    CRESTRONID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CRESTRONID__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CRESTRONID__DOLLAR____AnalogSerialOutput__, CRESTRONID__DOLLAR__ );
    
    VERSION__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( VERSION__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( VERSION__DOLLAR____AnalogSerialOutput__, VERSION__DOLLAR__ );
    
    ERRORMSG__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ERRORMSG__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ERRORMSG__DOLLAR____AnalogSerialOutput__, ERRORMSG__DOLLAR__ );
    
    P_SWITCHIP = new StringParameter( P_SWITCHIP__Parameter__, this );
    m_ParameterList.Add( P_SWITCHIP__Parameter__, P_SWITCHIP );
    
    P_SWITCHPORT = new StringParameter( P_SWITCHPORT__Parameter__, this );
    m_ParameterList.Add( P_SWITCHPORT__Parameter__, P_SWITCHPORT );
    
    P_SWITCHUSERNAME = new StringParameter( P_SWITCHUSERNAME__Parameter__, this );
    m_ParameterList.Add( P_SWITCHUSERNAME__Parameter__, P_SWITCHUSERNAME );
    
    P_SWITCHPASSWORD = new StringParameter( P_SWITCHPASSWORD__Parameter__, this );
    m_ParameterList.Add( P_SWITCHPASSWORD__Parameter__, P_SWITCHPASSWORD );
    
    P_SWITCHLICENCEKEY = new StringParameter( P_SWITCHLICENCEKEY__Parameter__, this );
    m_ParameterList.Add( P_SWITCHLICENCEKEY__Parameter__, P_SWITCHLICENCEKEY );
    
    WAIT_FOR_RX_SEND_Callback = new WaitFunction( WAIT_FOR_RX_SEND_CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_1___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_1___CallbackFn );
    LICENCE_TEXT_Callback = new WaitFunction( LICENCE_TEXT_CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_2___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_2___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_3___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_3___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_4___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_4___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_5___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_5___CallbackFn );
    
    START_MODULE.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_MODULE_OnPush_0, false ) );
    REFRESH_STATUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( REFRESH_STATUS_OnPush_1, false ) );
    SEND_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_SAVE_OnPush_2, false ) );
    POE_CMD.OnSerialChange.Add( new InputChangeHandlerWrapper( POE_CMD_OnChange_3, false ) );
    FAVOUTITE_CMD.OnSerialChange.Add( new InputChangeHandlerWrapper( FAVOUTITE_CMD_OnChange_4, false ) );
    DEBUGENABLE.OnSerialChange.Add( new InputChangeHandlerWrapper( DEBUGENABLE_OnChange_5, false ) );
    CRESTRON_MAC.OnSerialChange.Add( new InputChangeHandlerWrapper( CRESTRON_MAC_OnChange_6, false ) );
    for( uint i = 0; i < 404; i++ )
        OUTPUT[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( OUTPUT_OnChange_7, false ) );
        
    SWITCH_CLIENT.OnSocketConnect.Add( new SocketHandlerWrapper( SWITCH_CLIENT_OnSocketConnect_8, false ) );
    SWITCH_CLIENT.OnSocketDisconnect.Add( new SocketHandlerWrapper( SWITCH_CLIENT_OnSocketDisconnect_9, false ) );
    SWITCH_CLIENT.OnSocketStatus.Add( new SocketHandlerWrapper( SWITCH_CLIENT_OnSocketStatus_10, false ) );
    __TRIGGER_PROCESS_SOCKET_RECEIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( __TRIGGER_PROCESS_SOCKET_RECEIVE_OnPush_11, false ) );
    __TRIGGER_SEND_NEXT_CMD.OnDigitalPush.Add( new InputChangeHandlerWrapper( __TRIGGER_SEND_NEXT_CMD_OnPush_12, false ) );
    __TRIGGER_HEARTBEAT.OnDigitalPush.Add( new InputChangeHandlerWrapper( __TRIGGER_HEARTBEAT_OnPush_13, false ) );
    SWITCH_CLIENT.OnSocketReceive.Add( new SocketHandlerWrapper( SWITCH_CLIENT_OnSocketReceive_14, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_JAP_AVSWITCH_LUXUL_V1_03 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction WAIT_FOR_RX_SEND_Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_1___Callback;
private WaitFunction LICENCE_TEXT_Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_2___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_3___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_4___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_5___Callback;


const uint __TRIGGER_SEND_NEXT_CMD__DigitalInput__ = 0;
const uint __TRIGGER_HEARTBEAT__DigitalInput__ = 1;
const uint __TRIGGER_PROCESS_SOCKET_RECEIVE__DigitalInput__ = 2;
const uint REFRESH_STATUS__DigitalInput__ = 3;
const uint START_MODULE__DigitalInput__ = 4;
const uint SEND_SAVE__DigitalInput__ = 5;
const uint FAVOUTITE_CMD__AnalogSerialInput__ = 0;
const uint POE_CMD__AnalogSerialInput__ = 1;
const uint DEBUGENABLE__AnalogSerialInput__ = 2;
const uint CRESTRON_MAC__AnalogSerialInput__ = 3;
const uint OUTPUT__AnalogSerialInput__ = 4;
const uint __TRIGGER_SEND_NEXT_CMD_OUT__DigitalOutput__ = 0;
const uint __TRIGGER_START_HEARTBEAT_OUT__DigitalOutput__ = 1;
const uint __SOCKET_RECEIVE_BUSY__DigitalOutput__ = 2;
const uint REBOOTINGINPROGRESS__DigitalOutput__ = 3;
const uint OPERATIONFB__DOLLAR____AnalogSerialOutput__ = 0;
const uint CRESTRONID__DOLLAR____AnalogSerialOutput__ = 1;
const uint VERSION__DOLLAR____AnalogSerialOutput__ = 2;
const uint ERRORMSG__DOLLAR____AnalogSerialOutput__ = 3;
const uint NUMOFOUTPUTS__AnalogSerialOutput__ = 4;
const uint NUMOFINPUTS__AnalogSerialOutput__ = 5;
const uint OUTPUTFB__AnalogSerialOutput__ = 6;
const uint P_SWITCHIP__Parameter__ = 10;
const uint P_SWITCHPORT__Parameter__ = 11;
const uint P_SWITCHUSERNAME__Parameter__ = 12;
const uint P_SWITCHPASSWORD__Parameter__ = 13;
const uint P_SWITCHLICENCEKEY__Parameter__ = 14;

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

[SplusStructAttribute(-1, true, false)]
public class _0 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  _1;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  _2 = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  [] _3;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  [] _4;
    
    [SplusStructAttribute(4, false, false)]
    public CrestronString  _5;
    
    [SplusStructAttribute(5, false, false)]
    public ushort  _6 = 0;
    
    [SplusStructAttribute(6, false, false)]
    public ushort  _7 = 0;
    
    [SplusStructAttribute(7, false, false)]
    public ushort  _8 = 0;
    
    [SplusStructAttribute(8, false, false)]
    public ushort  _9 = 0;
    
    [SplusStructAttribute(9, false, false)]
    public ushort  [] _10;
    
    [SplusStructAttribute(10, false, false)]
    public short  [] _11;
    
    
    public _0( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        _3  = new ushort[ 11 ];
        _4  = new ushort[ 11 ];
        _10  = new ushort[ 11 ];
        _11  = new short[ 11 ];
        _1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 80, Owner );
        _5  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, Owner );
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class _41 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  _42 = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  _43 = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  _44 = 0;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  _45 = 0;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  _46 = 0;
    
    [SplusStructAttribute(5, false, false)]
    public ushort  _47 = 0;
    
    
    public _41( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class _71 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  _72;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  _73 = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  _74 = 0;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  _75;
    
    [SplusStructAttribute(4, false, false)]
    public CrestronString  _76;
    
    [SplusStructAttribute(5, false, false)]
    public ushort  _77 = 0;
    
    [SplusStructAttribute(6, false, false)]
    public CrestronString  _78;
    
    
    public _71( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        _72  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64000, Owner );
        _75  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, Owner );
        _76  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, Owner );
        _78  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class _80 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  _81 = 0;
    
    [SplusStructAttribute(1, false, false)]
    public uint  _82 = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  _83 = 0;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  _84 = 0;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  _85 = 0;
    
    
    public _80( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class _87 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  _88;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  _89;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  _90 = 0;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  _91;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  _92 = 0;
    
    [SplusStructAttribute(5, false, false)]
    public CrestronString  _93;
    
    
    public _87( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        _88  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, Owner );
        _89  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        _91  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        _93  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        
        
    }
    
}

}
