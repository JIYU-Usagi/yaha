using System;
using System.Collections.Generic;
using System.Linq;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.ApplicationServices;


namespace yaha
{
    public class Command : IExternalCommand
    {


        //이 안에서 코드 작성
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Application app = commandData.Application.Application;
            UIDocument UiDoc = commandData.Application.ActiveUIDocument;
            Document doc = UiDoc.Document;









            return Result.Succeeded;
        }
    }
}
