﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 10.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ItemWrapper.Generator
{
    using System;
    
    
    #line 1 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Main\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class GeneratorItem : Transformation
    {
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
        public override string TransformText()
        {
            this.GenerationEnvironment = null;
            this.Write("// This file is generated by ItemWrapper.Generator. Do not modify this file as it" +
                    " will be regenerated\r\nnamespace ");
            
            #line 3 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Main\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Store.Namespace));
            
            #line default
            #line hidden
            this.Write(" {\r\n\tusing System;\r\n\tusing System.Collections.Generic;\r\n\tusing System.Collections" +
                    ".Specialized;\r\n\tusing System.ComponentModel;\r\n\tusing System.Diagnostics;\r\n\tusing" +
                    " System.Globalization;\r\n\tusing System.Linq;\r\n\tusing System.Text;\r\n\tusing System." +
                    "Xml;\r\n\tusing ");
            
            #line 13 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Main\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.StoreNameSpace));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n");
            
            #line 15 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Main\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new GeneratorTableDefinition() {
		Generator = this.Generator
	}.TransformText()));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 20 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Main\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
if(this.Generator.RealmType != RealmType.None) {
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 22 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Main\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new GeneratorItemWrapper() {
		Generator = this.Generator
	}.TransformText()));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 28 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Main\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new GeneratorSetWrapper() {
		Generator = this.Generator
	}.TransformText()));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 33 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Main\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
}
            
            #line default
            #line hidden
            this.Write("}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
