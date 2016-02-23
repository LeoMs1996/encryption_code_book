﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryption_code_book.ViewModel
{
    public class note : notify_property
    {
        public note()
        {
           
        }

        private string _text;

        public string text
        {
            set
            {
                _text_stack.Push(_text);
                _text = value;
                OnPropertyChanged();
            }
            get
            {
                return _text;
            }
        }

        public void cancel()
        {
            try
            {
                _text = _text_stack.Pop();
            }
            catch (InvalidOperationException e)
            {
                reminder("没有修改" + e.Message + "\n");
            }
        }

        private readonly Stack<string> _text_stack=new Stack<string>();
    }
}