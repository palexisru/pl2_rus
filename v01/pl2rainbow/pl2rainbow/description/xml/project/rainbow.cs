using System;
using System.Data;
using pl2.rainbow.description;

namespace pl2.rainbow.description.xml.project {


    public partial class Rainbow
    {
        public void create_default_project()
        {
            Int32 project_id = 0;
            ProjectRow row;

            row = (ProjectRow)Project.NewRow();
            row.project_name = "Проект 1";
            row.project_description = "Описание проекта 1";
            Project.Rows.Add(row);
            AcceptChanges();
            row = (ProjectRow)Project.Rows[0];
            project_id = row.project_id;
            create_default_cells_for_project(project_id);
            AcceptChanges();


        }

        private void create_default_cells_for_project(int project_id)
        {
            CellRow row;
            foreach (Cell cell in Sphere.cell_collection)
            {
                row = (CellRow) Cell.NewRow();
                row.project_id = project_id;
                row.cell_level = (Int32) cell.abstraction ;
                row.cell_phase = (Int32) cell.phase ;
                row.cell_common_name = cell.default_name;
                Cell.AddCellRow(row);
            }
            Cell.AcceptChanges();
        }

        partial class Link_elementsDataTable
        {
        }
    
        partial class ProjectDataTable
        {
        }

    }
}
