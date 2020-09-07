﻿// Copyright (c) 2010-2014 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.Globalization;

namespace SharpGen.Runtime
{
    /// <summary>
    ///   The base class for errors that occur in native code invoked by SharpGen.
    /// </summary>
    public class SharpGenException : Exception
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref = "SharpGenException" /> class.
        /// </summary>
        public SharpGenException() : base("A SharpGen exception occurred.")
        {
            Descriptor = ResultDescriptor.Find(Result.Fail);
            HResult = (int)Result.Fail;
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref = "SharpGenException" /> class.
        /// </summary>
        /// <param name = "result">The result code that caused this exception.</param>
        public SharpGenException(Result result)
            : this(ResultDescriptor.Find(result))
        {
            HResult = (int)result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpGenException"/> class.
        /// </summary>
        /// <param name="descriptor">The result descriptor.</param>
        public SharpGenException(ResultDescriptor descriptor)
            : base(descriptor.ToString())
        {
            Descriptor = descriptor;
            HResult = (int)descriptor.Result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpGenException"/> class.
        /// </summary>
        /// <param name="result">The error result code.</param>
        /// <param name="message">The message describing the exception.</param>
        public SharpGenException(Result result, string message)
            : base(message)
        {
            Descriptor = ResultDescriptor.Find(result);
            HResult = (int)result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpGenException"/> class.
        /// </summary>
        /// <param name="result">The error result code.</param>
        /// <param name="message">The message describing the exception.</param>
        /// <param name="args">formatting arguments</param>
        public SharpGenException(Result result, string message, params object[] args)
            : base(string.Format(CultureInfo.InvariantCulture, message, args))
        {
            Descriptor = ResultDescriptor.Find(result);
            HResult = (int)result;
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref = "SharpGenException" /> class.
        /// </summary>
        /// <param name = "message">The message describing the exception.</param>
        /// <param name="args">formatting arguments</param>
        public SharpGenException(string message, params object[] args) : this(Result.Fail, message, args)
        {
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref = "SharpGenException" /> class.
        /// </summary>
        /// <param name = "message">The message describing the exception.</param>
        /// <param name = "innerException">The exception that caused this exception.</param>
        /// <param name="args">formatting arguments</param>
        public SharpGenException(string message, Exception innerException, params object[] args)
            : base(string.Format(CultureInfo.InvariantCulture, message, args), innerException)
        {
            Descriptor = ResultDescriptor.Find(Result.Fail);
            HResult = (int)Result.Fail;
        }

        /// <summary>
        ///   Gets the <see cref = "SharpGen.Runtime.Result">Result code</see> for the exception if one exists. This value indicates
        ///   the specific type of failure that occurred within the native code.
        /// </summary>
        public Result ResultCode => Descriptor?.Result ?? HResult;

        /// <summary>
        ///   Gets the <see cref = "SharpGen.Runtime.ResultDescriptor">Result descriptor</see> for the exception. This value indicates
        ///   the specific type of failure that occurred within the native code.
        /// </summary>
        public ResultDescriptor Descriptor { get; }
    }
}