//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using System;

namespace Microsoft.PowerShell.EditorServices.Console
{
    /// <summary>
    /// Defines an abstract base class for prompt handler implementations.
    /// </summary>
    public abstract class PromptHandler
    {
        /// <summary>
        /// Called when the active prompt should be cancelled.
        /// </summary>
        public void CancelPrompt()
        {
            // Allow the implementation to clean itself up
            this.OnPromptCancelled();
            this.PromptCancelled?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// An event that gets raised if the prompt is cancelled, either
        /// by the user or due to a timeout.
        /// </summary>
        public event EventHandler PromptCancelled;

        /// <summary>
        /// Implementation classes may override this method to perform
        /// cleanup when the CancelPrompt method gets called.
        /// </summary>
        protected virtual void OnPromptCancelled()
        {
        }
    }
}

