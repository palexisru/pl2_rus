using System;
using System.Data;
using System.Linq;
using pl2.rainbow.description;

namespace pl2.rainbow.description.xml.project {


    public partial class Rainbow
    {
        partial class Element_tableDataTable
        {
        }
        /// <summary>
        /// идентификатор текущего проекта
        /// </summary>
        Int32 project_id;

        partial class Phase_tableDataTable
        {
        }

        public void create_default_project()
        {
            create_default_empty_project();
            create_default_elements();
            create_default_element_links();

        }

        private void create_default_element_links()
        {
            
            //throw new NotImplementedException();
        }

        private void create_default_elements()
        {
            Element_tableRow row;
            foreach( Cell_tableRow cell_row in Cell_table.Rows)
            {
                row = (Element_tableRow) Element_table.NewRow();
                row.project_id = cell_row.project_id;
                row.element_level = cell_row.cell_level;
                row.element_phase = cell_row.cell_phase;
                row.element_name = "element " + cell_row.cell_common_name;
                Element_table.AddElement_tableRow(row);
            }
        }
    
        public void create_default_empty_project()
        {
            Project_tableRow row;

            row = (Project_tableRow) Project_table.NewRow();
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
                row.cell_level = (Int32)cell.abstraction;
                row.cell_phase = (Int32)cell.phase;
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

        private void create_default_importence()
        {
            Importance_tableRow row;
            row = (Importance_tableRow)Importance_table.NewRow();
            row.importance_id = (Int32)pl2.rainbow.description.Importance_enum.reserved;
            row.importance_name = Importance_enum.reserved.ToString();
            row.importance_percent = 0 + 12;
            Importance_table.AddImportance_tableRow( row );
            row = (Importance_tableRow)Importance_table.NewRow();
            row.importance_id = (Int32)pl2.rainbow.description.Importance_enum.probably; ;
            row.importance_name = Importance_enum.probably.ToString();
            row.importance_percent = 25 + 12;
            Importance_table.AddImportance_tableRow( row );
            row = (Importance_tableRow)Importance_table.NewRow();
            row.importance_id = (Int32)pl2.rainbow.description.Importance_enum.important;
            row.importance_name = Importance_enum.important.ToString();
            row.importance_percent = 50 + 12;
            Importance_table.AddImportance_tableRow( row );
            row = (Importance_tableRow)Importance_table.NewRow();
            row.importance_id = (Int32)pl2.rainbow.description.Importance_enum.main;
            row.importance_name = Importance_enum.main.ToString();
            row.importance_percent = 75 + 12;
            Importance_table.AddImportance_tableRow( row );
            Importance_table.AcceptChanges();

        }

        private void create_default_phase()
        {
            Phase_tableRow row;
            row = (Phase_tableRow) Phase_table.NewRow();
            row.phase_id = (Int32)Phase_direction_enum.invariant;
            row.phase_name = Phase_direction_enum.invariant.ToString();
            row.phase_importance = (Int32)Importance_enum.main;
            Phase_table.AddPhase_tableRow(row);

            row = (Phase_tableRow)Phase_table.NewRow();
            row.phase_id = (Int32)Phase_direction_enum.before;
            row.phase_name = Phase_direction_enum.before.ToString();
            row.phase_importance = (Int32)Importance_enum.main;
            Phase_table.AddPhase_tableRow( row );

            row = (Phase_tableRow)Phase_table.NewRow();
            row.phase_id = (Int32)Phase_direction_enum.action;
            row.phase_name = Phase_direction_enum.action.ToString();
            row.phase_importance = (Int32)Importance_enum.main;
            Phase_table.AddPhase_tableRow( row );

            row = (Phase_tableRow)Phase_table.NewRow();
            row.phase_id = (Int32)Phase_direction_enum.after;
            row.phase_name = Phase_direction_enum.after.ToString();
            row.phase_importance = (Int32)Importance_enum.main;
            Phase_table.AddPhase_tableRow( row );

            Phase_table.AcceptChanges();
        }

        private void create_default_levels()
        {
            Level_tableRow row;
            foreach (Abstraction_system level in Sphere.abstruction_collection)
            {
                row = (Level_tableRow) Level_table.NewRow();
                row.level_id = (Int32) level.abstraction_level;
                row.level_name = level.abstraction_level.ToString();
                row.level_importance = (Int32) level.importance ;
                Level_table.AddLevel_tableRow( row );
            }
            Cell_table.AcceptChanges();
        }

         partial class Link_elements_tableDataTable
        {
        }

        partial class Project_tableDataTable
        {
        }

    }
}
