﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 10.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace LogicCircuit
{
    using System.Linq;
    using System;
    
    
    #line 1 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class ReportBuilder : T4Transformation
    {
        public override string TransformText()
        {
            this.Write("<FlowDocument xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\">\r" +
                    "\n\t<Paragraph FontSize=\"20\" FontWeight=\"Bold\">");
            
            #line 4 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Resources.CommandCircuitProject));
            
            #line default
            #line hidden
            this.Write(" \"");
            
            #line 4 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.Name));
            
            #line default
            #line hidden
            this.Write("\"</Paragraph>\r\n\t<Paragraph><Bold>");
            
            #line 5 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Resources.TitleProjectDescription));
            
            #line default
            #line hidden
            this.Write("</Bold> ");
            
            #line 5 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.Description));
            
            #line default
            #line hidden
            this.Write("</Paragraph>\r\n\t<Paragraph><Bold>");
            
            #line 6 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Resources.TitleSummary));
            
            #line default
            #line hidden
            this.Write("</Bold>\r\n\t\t");
            
            #line 7 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Resources.ProjectSummary(
			this.Project.CircuitProject.LogicalCircuitSet.Count(),
			this.CategoryCount,
			this.Project.CircuitProject.CircuitSymbolSet.Count(),
			this.Project.CircuitProject.WireSet.Count()
		)));
            
            #line default
            #line hidden
            this.Write("\r\n\t</Paragraph>\r\n\t<Paragraph FontSize=\"20\" FontWeight=\"Bold\">");
            
            #line 14 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Resources.ReportFunctions(this.Root.Name)));
            
            #line default
            #line hidden
            this.Write("</Paragraph>\r\n");
            
            #line 15 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
if(this.BuildMapException == null) {
            
            #line default
            #line hidden
            this.Write("\t<Table CellSpacing=\"5\">\r\n\t\t<Table.Columns>\r\n\t\t\t<TableColumn/>\r\n\t\t\t<TableColumn/>" +
                    "\r\n\t\t</Table.Columns>\r\n\t\t<TableRowGroup>\r\n\t\t\t<TableRow Background=\"Gray\">\r\n\t\t\t\t<T" +
                    "ableCell><Paragraph FontSize=\"15\" FontWeight=\"Bold\">");
            
            #line 23 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Resources.TitleFunction));
            
            #line default
            #line hidden
            this.Write("</Paragraph></TableCell>\r\n\t\t\t\t<TableCell><Paragraph FontSize=\"15\" FontWeight=\"Bol" +
                    "d\">");
            
            #line 24 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Resources.TitleCount));
            
            #line default
            #line hidden
            this.Write("</Paragraph></TableCell>\r\n\t\t\t</TableRow>\r\n");
            
            #line 26 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
	for(int i = 0; i < this.Functions.Count; i++) {
            
            #line default
            #line hidden
            this.Write("\t\t\t<TableRow Background=\"");
            
            #line 27 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(((i & 1) == 0) ? "White" : "WhiteSmoke"));
            
            #line default
            #line hidden
            this.Write("\">\r\n\t\t\t\t<TableCell><Paragraph>");
            
            #line 28 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Functions[i]));
            
            #line default
            #line hidden
            this.Write("</Paragraph></TableCell>\r\n\t\t\t\t<TableCell><Paragraph>");
            
            #line 29 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Usage[this.Functions[i]]));
            
            #line default
            #line hidden
            this.Write("</Paragraph></TableCell>\r\n\t\t\t</TableRow>\r\n");
            
            #line 31 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
	}
            
            #line default
            #line hidden
            this.Write("\t\t\t<TableRow Background=\"Gray\">\r\n\t\t\t\t<TableCell><Paragraph FontWeight=\"Bold\">");
            
            #line 33 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Resources.TitleTotal));
            
            #line default
            #line hidden
            this.Write("</Paragraph></TableCell>\r\n\t\t\t\t<TableCell><Paragraph>");
            
            #line 34 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Usage.Values.Sum()));
            
            #line default
            #line hidden
            this.Write("</Paragraph></TableCell>\r\n\t\t\t</TableRow>\r\n\t\t</TableRowGroup>\r\n\t</Table>\r\n");
            
            #line 38 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
} else {
            
            #line default
            #line hidden
            this.Write("\t<Paragraph FontSize=\"20\" FontWeight=\"Bold\">");
            
            #line 39 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Resources.ReportError(this.BuildMapException.Message)));
            
            #line default
            #line hidden
            this.Write("</Paragraph>\r\n\t<Paragraph FontSize=\"8\" FontWeight=\"Bold\">");
            
            #line 40 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Resources.TitleReportErrorDetails));
            
            #line default
            #line hidden
            this.Write("</Paragraph>\r\n\t<Paragraph FontSize=\"8\">");
            
            #line 41 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.BuildMapException.ToString()));
            
            #line default
            #line hidden
            this.Write("</Paragraph>\r\n");
            
            #line 42 "C:\Eugene\Projects\LogicCircuit\LogicCircuit\Work\Sources\LogicCircuit\Dialog\ReportBuilder.tt"
}
            
            #line default
            #line hidden
            this.Write("</FlowDocument>\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
