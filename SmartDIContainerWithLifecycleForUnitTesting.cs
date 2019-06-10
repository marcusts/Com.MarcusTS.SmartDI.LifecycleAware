﻿// *********************************************************************************
// <copyright file=SmartDIContainerWithLifecycleForUnitTesting.cs company="Marcus Technical Services, Inc.">
//     Copyright @2019 Marcus Technical Services, Inc.
// </copyright>
//
// MIT License
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// *********************************************************************************

namespace Com.MarcusTS.SmartDI.LifecycleAware
{
   using Com.MarcusTS.SharedForms.Utils;

   /// <summary>
   ///    Interface ISmartDIContainerWithLifecycleForUnitTesting
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.ISmartDIContainerForUnitTesting" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.ISmartDIContainerForUnitTesting" />
   public interface ISmartDIContainerWithLifecycleForUnitTesting : ISmartDIContainerForUnitTesting
   {
   }

   /// <summary>
   ///    Class SmartDIContainerWithLifecycleForUnitTesting.
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.SmartDIContainerForUnitTesting" />
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.LifecycleAware.ISmartDIContainerWithLifecycleForUnitTesting" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.SmartDIContainerForUnitTesting" />
   /// <seealso cref="Com.MarcusTS.SmartDI.LifecycleAware.ISmartDIContainerWithLifecycleForUnitTesting" />
   public class SmartDIContainerWithLifecycleForUnitTesting : SmartDIContainerForUnitTesting,
                                                              ISmartDIContainerWithLifecycleForUnitTesting
   {
      /// <summary>
      ///    Initializes a new instance of the <see cref="SmartDIContainerWithLifecycleForUnitTesting" /> class.
      /// </summary>
      public SmartDIContainerWithLifecycleForUnitTesting()
      {
         FormsMessengerUtils.Subscribe<ObjectDisappearingMessage>(this, OnObjectDisappearing);
      }

      /// <summary>
      ///    Called when [object disappearing].
      /// </summary>
      /// <param name="sender">The sender.</param>
      /// <param name="mess">The mess.</param>
      private void OnObjectDisappearing
      (
         object                    sender,
         ObjectDisappearingMessage mess
      )
      {
         ContainerObjectIsDisappearing(mess.Payload);
      }
   }
}