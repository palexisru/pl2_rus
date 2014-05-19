using System;
using System.Data;
using pl2.rainbow.description;

namespace pl2.rainbow.description.xml.project {


    public partial class Rainbow
    {
        partial class Phase_tableDataTable
        {
        }
    
        public void create_default_project()
        {
            Int32 project_id = 0;
            Project_tableRow row;

            row = (Project_tableRow)Project_table.NewRow();
            row.project_name = "Проект 1";
            row.project_description = "Описание проекта 1";
            Project_table.Rows.Add(row);
            AcceptChanges();
            row = (Project_tableRow)Project_table.Rows[0];
            project_id = row.project_id;
            create_default_cells_for_project(project_id);
            AcceptChanges();


        }

        private void create_default_cells_for_project(int project_id)
        {
            Cell_tableRow row;
            create_default_meagure();
            foreach (Cell_system cell in Sphere.cell_collection)
            {
                row = (Cell_tableRow) Cell_table.NewRow();
                row.project_id = project_id;
                row.cell_level = (Single)cell.abstraction;
                row.cell_phase = (Single)cell.phase;
                row.cell_common_name = cell.default_name;
                Cell_table.AddCell_tableRow(row);
            }
            Cell_table.AcceptChanges();
        }

        private void create_default_meagure()
        {
            create_default_importence();
            create_default_phase();
            create_default_levels();
                
        }

        private void create_default_levels()
        {
            throw new NotImplementedException();
        }

        private void create_default_phase()
        {
            throw new NotImplementedException();
        }

        private void create_default_importence()
        {
            Importance_tableRow row;
            row = (Importance_tableRow)Importance_table.NewRow();
            row.importance_id = (Int32)pl2.rainbow.description.Importance_enum.Level_reserved;
            row.importance_name = Importance_enum.Level_reserved.ToString();
            row.importance_percent = 75+12;
            Importance_table.AddImportance_tableRow( row );
            row = (Importance_tableRow)Importance_table.NewRow();
            row.importance_id = (Int32)pl2.rainbow.description.Importance_enum.Level_main;
            row.importance_name = Importance_enum.Level_main.ToString();
            row.importance_percent = 50+12;
            Importance_table.AddImportance_tableRow( row );
            row = (Importance_tableRow)Importance_table.NewRow();
            row.importance_id = (Int32)pl2.rainbow.description.Importance_enum.Level_main;
            row.importance_name = Importance_enum.Level_main.ToString();
            row.importance_percent = 25+12;
            Importance_table.AddImportance_tableRow( row );
            row = (Importance_tableRow)Importance_table.NewRow();
            row.importance_id = (Int32)pl2.rainbow.description.Importance_enum.Level_main;
            row.importance_name = Importance_enum.Level_main.ToString();
            row.importance_percent = 0+12;
            Importance_table.AddImportance_tableRow( row );
            Importance_table.AcceptChanges();
            
        }

        partial class Link_elements_tableDataTable
        {
        }

        partial class Project_tableDataTable
        {
        }

    }
}
