﻿using System.Collections.Generic;

namespace JohnBryce
{
    class Errors
    {
        private List<string> errors { get; set; } = new List<string>();

        public void Add(string errorMessage)
        {
            errors.Add(errorMessage);
        }
    }
}
