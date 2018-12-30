// *********************************************************************************
// Assembly         : Com.MarcusTS.SmartDI.LifecycleAware
// Author           : Stephen Marcus (Marcus Technical Services, Inc.)
// Created          : 12-26-2018
// Last Modified On : 12-27-2018
//
// <copyright file="SmartDIContainerWithLifecycleForUnitTesting.cs" company="Com.MarcusTS.SmartDI.LifecycleAware">
//     Copyright (c) . All rights reserved.
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
   using SharedForms.Utils;

   /// <summary>
   /// Interface ISmartDIContainerWithLifecycleForUnitTesting
   /// Implements the <see cref="Com.MarcusTS.SmartDI.ISmartDIContainerForUnitTesting" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.ISmartDIContainerForUnitTesting" />
   public interface ISmartDIContainerWithLifecycleForUnitTesting : ISmartDIContainerForUnitTesting
   { }

   /// <summary>
   /// Class SmartDIContainerWithLifecycleForUnitTesting.
   /// Implements the <see cref="Com.MarcusTS.SmartDI.SmartDIContainerForUnitTesting" />
   /// Implements the <see cref="Com.MarcusTS.SmartDI.LifecycleAware.ISmartDIContainerWithLifecycleForUnitTesting" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.SmartDIContainerForUnitTesting" />
   /// <seealso cref="Com.MarcusTS.SmartDI.LifecycleAware.ISmartDIContainerWithLifecycleForUnitTesting" />
   public class SmartDIContainerWithLifecycleForUnitTesting : SmartDIContainerForUnitTesting,
                                                              ISmartDIContainerWithLifecycleForUnitTesting
   {
      #region Public Constructors

      /// <summary>
      /// Initializes a new instance of the <see cref="SmartDIContainerWithLifecycleForUnitTesting" /> class.
      /// </summary>
      public SmartDIContainerWithLifecycleForUnitTesting()
      {
         FormsMessengerUtils.Subscribe<ObjectDisappearingMessage>(this, OnObjectDisappearing);
      }

      #endregion Public Constructors

      #region Private Methods

      /// <summary>
      /// Called when [object disappearing].
      /// </summary>
      /// <param name="sender">The sender.</param>
      /// <param name="mess">The mess.</param>
      private void OnObjectDisappearing(object                    sender,
                                        ObjectDisappearingMessage mess)
      {
         ContainerObjectIsDisappearing(mess.Payload);
      }

      #endregion Private Methods
   }
}