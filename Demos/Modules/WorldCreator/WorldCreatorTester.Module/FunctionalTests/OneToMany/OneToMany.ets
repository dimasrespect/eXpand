﻿#IncludeFile .\Init.inc

*ReopenApplication
*LogOn
*Action Navigation(Default.Project)
*Action New
*FillForm
 Name = eXpandFramework
*Action Contributors.New
*FillForm
 Name = Tolis
*SaveAndClose
*CheckTable Contributors
 Columns = Name
 Row[0] = Tolis
*SaveAndClose
*Action Navigation(Default.Project)
*CheckTable
 Columns = Name
 Row[0] = eXpandFramework
