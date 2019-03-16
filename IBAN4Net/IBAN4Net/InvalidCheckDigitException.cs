﻿/*
 * IBAN4Net
 * 
 * Jose Novais, 2017
 * 
 * based on https://github.com/sinkien/IBAN4Net
 * 
 * changes:
 * 
 * - compiled for a portable library, .NETStandard 1.1
 * - added method IbanUtils.FromSameBank(iban1, iban2)
 * 
 * *********************************************************************
 * 
 * IBAN4Net
 * Copyright 2015 Vaclav Beca [sinkien]
 *
 * Based on Artur Mkrtchyan's project IBAN4j (https://github.com/arturmkrtchyan/iban4j).
 *
 *
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace IBAN4Net
{
    /// <summary>
    /// Exception which is thrown to indicate that IBAN's check digit is invalid.
    /// </summary>
    public class InvalidCheckDigitException : Exception
    {
        public string ActualString { get; private set; }
        public string ExpectedString { get; private set; }

        public InvalidCheckDigitException() : base()
        { }

        public InvalidCheckDigitException(string message) : base(message)
        { }

        public InvalidCheckDigitException(string message, Exception innerException) : base(message, innerException)
        { }

        public InvalidCheckDigitException (string format, params object[] args) : base( string.Format( format, args ) )
        { }

        public InvalidCheckDigitException(string message, string expected, string actual) : base (message)
        {
            ActualString = actual;
            ExpectedString = expected;
        }
    }
}
