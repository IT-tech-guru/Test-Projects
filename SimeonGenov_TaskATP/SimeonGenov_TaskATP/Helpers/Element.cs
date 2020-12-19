using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimeonGenov_TaskATP.Helpers
{
    public abstract class Element
    {
        public abstract By By { get; }
        public abstract string Text { get; }
        public abstract void TypeText(string text);
        public abstract void Click();
        public abstract string GetAttribute(string attributeName);

    }
}
