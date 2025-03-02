﻿//----------------------------------------------------------------------------
//
//  Copyright (C) 2004-2021 by EMGU Corporation. All rights reserved.
//
//  Vector of VectorOfMat
//
//  This file is automatically generated, do not modify.
//----------------------------------------------------------------------------



using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Emgu.CV.Structure;

namespace Emgu.CV.Util
{
   /// <summary>
   /// Wrapped class of the C++ standard vector of VectorOfMat.
   /// </summary>
   [Serializable]
   [DebuggerTypeProxy(typeof(VectorOfVectorOfMat.DebuggerProxy))]
   public partial class VectorOfVectorOfMat : Emgu.CV.Util.UnmanagedVector
#if false
      , IInputOutputArray
#endif
   {
      private readonly bool _needDispose;
   
      static VectorOfVectorOfMat()
      {
         CvInvoke.Init();
      }

      /// <summary>
      /// Create an empty standard vector of VectorOfMat
      /// </summary>
      public VectorOfVectorOfMat()
         : this(VectorOfVectorOfMatCreate(), true)
      {
      }

      internal VectorOfVectorOfMat(IntPtr ptr, bool needDispose)
      {
         _ptr = ptr;
         _needDispose = needDispose;
      }

      /// <summary>
      /// Create an standard vector of VectorOfMat of the specific size
      /// </summary>
      /// <param name="size">The size of the vector</param>
      public VectorOfVectorOfMat(int size)
         : this( VectorOfVectorOfMatCreateSize(size), true)
      {
      }

      /// <summary>
      /// Create an standard vector of VectorOfMat with the initial values
      /// </summary>
      /// <param name="values">The initial values</param>
      public VectorOfVectorOfMat(params VectorOfMat[] values)
        : this()
      {
        Push(values);
      }

      /// <summary>
      /// Get the size of the vector
      /// </summary>
      public override int Size
      {
         get
         {
            return VectorOfVectorOfMatGetSize(_ptr);
         }
      }
	  
	  /// <summary>
      /// The pointer to the first element on the vector. In case of an empty vector, IntPtr.Zero will be returned.
      /// </summary>
      public override IntPtr StartAddress
      {
         get
         {
            return VectorOfVectorOfMatGetStartAddress(_ptr);
         }
      }
	  
	  /// <summary>
      /// The pointer to memory address at the end of the vector. In case of an empty vector, IntPtr.Zero will be returned.
      /// </summary>
      public override IntPtr EndAddress
      {
         get
         {
            return VectorOfVectorOfMatGetEndAddress(_ptr);
         }
      }

      /// <summary>
      /// Clear the vector
      /// </summary>
      public void Clear()
      {
         VectorOfVectorOfMatClear(_ptr);
      }

      /// <summary>
      /// Push a value into the standard vector
      /// </summary>
      /// <param name="value">The value to be pushed to the vector</param>
      public void Push(VectorOfMat value)
      {
         VectorOfVectorOfMatPush(_ptr, value.Ptr);
      }

      /// <summary>
      /// Push multiple values into the standard vector
      /// </summary>
      /// <param name="values">The values to be pushed to the vector</param>
      public void Push(VectorOfMat[] values)
      {
         foreach (VectorOfMat value in values)
            Push(value);
      }

      /// <summary>
      /// Push multiple values from the other vector into this vector
      /// </summary>
      /// <param name="other">The other vector, from which the values will be pushed to the current vector</param>
      public void Push(VectorOfVectorOfMat other)
      {
         VectorOfVectorOfMatPushVector(_ptr, other);
      }
      
      /// <summary>
      /// Get the item in the specific index
      /// </summary>
      /// <param name="index">The index</param>
      /// <returns>The item in the specific index</returns>
      public VectorOfMat this[int index]
      {
         get
         {
            IntPtr itemPtr = IntPtr.Zero;
            VectorOfVectorOfMatGetItemPtr(_ptr, index, ref itemPtr);
            return new VectorOfMat(itemPtr, false);
         }
      }

      /// <summary>
      /// Release the standard vector
      /// </summary>
      protected override void DisposeObject()
      {
         if (_needDispose && _ptr != IntPtr.Zero)
            VectorOfVectorOfMatRelease(ref _ptr);
      }

#if false
      /// <summary>
      /// Get the pointer to cv::_InputArray
      /// </summary>
      /// <returns>The input array</returns>
      public InputArray GetInputArray()
      {
        return new InputArray( cveInputArrayFromVectorOfVectorOfMat(_ptr), this );
      }

      /// <summary>
      /// Get the pointer to cv::_OutputArray
      /// </summary>
      /// <returns>The output array</returns>
      public OutputArray GetOutputArray()
      {
         return new OutputArray( cveOutputArrayFromVectorOfVectorOfMat(_ptr), this );
      }

      /// <summary>
      /// Get the pointer to cv::_InputOutputArray
      /// </summary>
      /// <returns>The input output array</returns>
      public InputOutputArray GetInputOutputArray()
      {
         return new InputOutputArray( cveInputOutputArrayFromVectorOfVectorOfMat(_ptr), this );
      }
#endif
      
      /// <summary>
      /// The size of the item in this Vector, counted as size in bytes.
      /// </summary>
      public static int SizeOfItemInBytes
      {
         get { return VectorOfVectorOfMatSizeOfItemInBytes(); }
      }

#if false
      /// <summary>
      /// Create the standard vector of VectorOfMat 
      /// </summary>
      /// <param name="values">The values to be pushed to the vector</param>
      public VectorOfVectorOfMat(Rectangle[][] values)
         : this()
      {
         using (VectorOfMat v = new VectorOfMat())
         {
            for (int i = 0; i < values.Length; i++)
            {
               v.Push(values[i]);
               Push(v);
               v.Clear();
            }
         }
      }

      /// <summary>
      /// Convert the standard vector to arrays of arrays of Rectangle
      /// </summary>
      /// <returns>Arrays of arrays of the Rectangle</returns>
      public Rectangle[][] ToArrayOfArray()
      {
         int size = Size;
         Rectangle[][] res = new Rectangle[size][];
         for (int i = 0; i < size; i++)
         {
            using (VectorOfMat v = this[i])
            {
               res[i] = v.ToArray();
            }
         }
         return res;
      }
#endif

      internal class DebuggerProxy
      {
         private VectorOfVectorOfMat _v;

         public DebuggerProxy(VectorOfVectorOfMat v)
         {
            _v = v;
         }

#if false
         public Rectangle[][] Values
         {
            get { return _v.ToArrayOfArray(); }
         }
#else
         public VectorOfMat[] Values
         {
            get
            {
               VectorOfMat[] result = new VectorOfMat[_v.Size];
               for (int i = 0; i < result.Length; i++)
               {
                  result[i] = _v[i];
               }
               return result;
            }
         }
#endif
      }


      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfVectorOfMatCreate();

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfVectorOfMatCreateSize(int size);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfVectorOfMatRelease(ref IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfVectorOfMatGetSize(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfVectorOfMatGetStartAddress(IntPtr v);
	  
	  [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfVectorOfMatGetEndAddress(IntPtr v);
	  
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfVectorOfMatPush(IntPtr v, IntPtr value);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfVectorOfMatPushVector(IntPtr ptr, IntPtr otherPtr);
      
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfVectorOfMatClear(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfVectorOfMatGetItemPtr(IntPtr vec, int index, ref IntPtr element);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfVectorOfMatSizeOfItemInBytes();

#if false
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cveInputArrayFromVectorOfVectorOfMat(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cveOutputArrayFromVectorOfVectorOfMat(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cveInputOutputArrayFromVectorOfVectorOfMat(IntPtr vec);
#endif
   }
}


