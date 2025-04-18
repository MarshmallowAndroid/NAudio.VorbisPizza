﻿using System;

namespace NAudio.VorbisPizza
{
    /// <summary>
    /// Arguments for the EndOfStream event.
    /// </summary>
    [Serializable]
    public class EndOfStreamEventArgs : EventArgs
    {
        /// <summary>
        /// Creates a new instance of <see cref="EndOfStreamEventArgs"/>.
        /// </summary>
        public EndOfStreamEventArgs() { }

        /// <summary>
        /// Gets or sets whether to auto-advance to the next stream.
        /// </summary>
        public bool AdvanceToNextStream { get; set; }

        /// <summary>
        /// Gets or sets whether to remember the ended stream or dispose and remove it from the list.
        /// </summary>
        public bool KeepStream { get; set; } = true;
    }
}
