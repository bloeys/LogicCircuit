﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ItemWrapper.Generator
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class GeneratorItem : Transformation
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("// This file is generated by ItemWrapper.Generator. Do not modify this file as it" +
                    " will be regenerated\r\nnamespace ");
            
            #line 3 "C:\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Store.Namespace));
            
            #line default
            #line hidden
            this.Write(" {\r\n\tusing System;\r\n\tusing System.Collections.Generic;\r\n\tusing System.Collections" +
                    ".Specialized;\r\n\tusing System.ComponentModel;\r\n\tusing System.Diagnostics;\r\n\tusing" +
                    " System.Globalization;\r\n\tusing System.Linq;\r\n\tusing System.Text;\r\n\tusing ");
            
            #line 12 "C:\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.StoreNameSpace));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n");
            
            #line 14 "C:\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new GeneratorTableDefinition() {
		Generator = this.Generator
	}.TransformText()));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 19 "C:\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
if(this.Generator.RealmType != RealmType.None) {
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 21 "C:\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new GeneratorItemWrapper() {
		Generator = this.Generator
	}.TransformText()));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 27 "C:\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new GeneratorSetWrapper() {
		Generator = this.Generator
	}.TransformText()));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 32 "C:\Projects\LogicCircuit\LogicCircuit\Work\Sources\Tools\ItemWrapper.Generator\GeneratorItem.tt"
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
