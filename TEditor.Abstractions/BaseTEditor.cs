﻿using System;
using System.Threading.Tasks;

namespace TEditor.Abstractions
{
    public abstract class BaseTEditor : ITEditor, IDisposable
    {
        public abstract Task<string> ShowTEditor(string html, ToolbarBuilder toolbarBuilder = null);

        /// <summary>
        /// Dispose of class and parent classes
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose up
        /// </summary>
        ~BaseTEditor()
        {
            Dispose(false);
        }
        private bool disposed = false;
        /// <summary>
        /// Dispose method
        /// </summary>
        /// <param name="disposing"></param>
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //dispose only
                }

                disposed = true;
            }
        }
    }
}
