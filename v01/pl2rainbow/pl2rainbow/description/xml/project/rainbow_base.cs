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
            Link_elements_tableRow row;
            foreach( Element_tableRow element_row in Element_table.Rows)
            {
                var possible_links_next = 
                    from element in Element_table 
                        join level in Level_table
                        on element.level_id_for_element equals level.level_id
                    where ((Int32)level.importance_id_for_level) <= 3
                        && ((Int32) element.phase_id_for_element == (Int32) element_row.phase_id_for_element + 1)
                    select element;
                foreach(Element_tableRow el_row in possible_links_next)
                {
                    row = (Link_elements_tableRow)Link_elements_table.NewRow();
                    row.parent_element_id_for_link = element_row.element_id;
                    row.chield_element_id_for_link = el_row.element_id;
                    row.description_for_link = element_row.name_of_element + " -> " + el_row.name_of_element;
                    Link_elements_table.AddLink_elements_tableRow(row);
                }

                var possible_links_prev =
                    from element in Element_table
                    where element.level_id_for_element == element_row.level_id_for_element
                        && ((Int32)element.phase_id_for_element == (Int32)element_row.phase_id_for_element - 1)
                    select element;
                foreach (Element_tableRow el_row in possible_links_prev)
                {
                    row = (Link_elements_tableRow)Link_elements_table.NewRow();
                    row.parent_element_id_for_link = element_row.element_id;
                    row.chield_element_id_for_link = el_row.element_id;
                    row.description_for_link = element_row.name_of_element + " -> " + el_row.name_of_element;
                    Link_elements_table.AddLink_elements_tableRow( row );
                }

                var possible_links_upper =
                    from element in Element_table
                    where (Int32)element.level_id_for_element == (Int32)element_row.level_id_for_element + 1
                        && (element.phase_id_for_element == element_row.phase_id_for_element)
                    select element;
                foreach (Element_tableRow el_row in possible_links_upper)
                {
                    row = (Link_elements_tableRow)Link_elements_table.NewRow();
                    row.parent_element_id_for_link = element_row.element_id;
                    row.chield_element_id_for_link = el_row.element_id;
                    row.description_for_link = element_row.name_of_element + " -> " + el_row.name_of_element;
                    Link_elements_table.AddLink_elements_tableRow( row );
                }

                var possible_links_lower =
                    from element in Element_table
                    where (Int32)element.level_id_for_element == (Int32)element_row.level_id_for_element - 1
                        && (element.phase_id_for_element == element_row.phase_id_for_element)
                    select element;
                foreach (Element_tableRow el_row in possible_links_lower)
                {
                    row = (Link_elements_tableRow)Link_elements_table.NewRow();
                    row.parent_element_id_for_link = element_row.element_id;
                    row.chield_element_id_for_link = el_row.element_id;
                    row.description_for_link = element_row.name_of_element + " -> " + el_row.name_of_element;
                    Link_elements_table.AddLink_elements_tableRow( row );
                }

                var possible_links_symmetric =
                    from element in Element_table
                    where Math.Abs((Int32)element.level_id_for_element) == Math.Abs((Int32)element_row.level_id_for_element)
                        && element.level_id_for_element != element_row.level_id_for_element
                        && (element.phase_id_for_element == element_row.phase_id_for_element)
                    select element;
                foreach (Element_tableRow el_row in possible_links_symmetric)
                {
                    row = (Link_elements_tableRow)Link_elements_table.NewRow();
                    row.parent_element_id_for_link = element_row.element_id;
                    row.chield_element_id_for_link = el_row.element_id;
                    row.description_for_link = element_row.name_of_element + " -> " + el_row.name_of_element;
                    Link_elements_table.AddLink_elements_tableRow( row );
                }

            }
            
            //throw new NotImplementedException();
        }

        private void create_default_elements()
        {
            Element_tableRow row;
            foreach( Cell_tableRow cell_row in Cell_table.Rows)
            {
                row = (Element_tableRow) Element_table.NewRow();
                row.project_id_for_element = cell_row.project_id_for_cell;
                row.level_id_for_element = cell_row.level_id_for_cell;
                row.phase_id_for_element = cell_row.phase_id_for_cell;
                row.name_of_element = "element " + cell_row.name_of_cell_common;
                Element_table.AddElement_tableRow(row);
            }
        }
    
        public void create_default_empty_project()
        {
            Project_tableRow row;

            row = (Project_tableRow) Project_table.NewRow();
            row.name_of_project = "Проект 1";
            row.description_for_project = "Описание проекта 1";
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
                row.project_id_for_cell = project_id;
                row.level_id_for_cell = (Int32)cell.abstraction;
                row.phase_id_for_cell = (Int32)cell.phase;
                row.name_of_cell_common = cell.default_name;
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
            row.name_of_importance = Importance_enum.reserved.ToString();
            row.percent_of_importance = 0 + 12;

            Importance_table.AddImportance_tableRow( row );
            row = (Importance_tableRow)Importance_table.NewRow();
            row.importance_id = (Int32)pl2.rainbow.description.Importance_enum.probably; ;
            row.name_of_importance = Importance_enum.probably.ToString();
            row.percent_of_importance = 25 + 12;

            Importance_table.AddImportance_tableRow( row );
            row = (Importance_tableRow)Importance_table.NewRow();
            row.importance_id = (Int32)pl2.rainbow.description.Importance_enum.important;
            row.name_of_importance = Importance_enum.important.ToString();
            row.percent_of_importance = 50 + 12;
            Importance_table.AddImportance_tableRow( row );

            row = (Importance_tableRow)Importance_table.NewRow();
            row.importance_id = (Int32)pl2.rainbow.description.Importance_enum.main;
            row.name_of_importance = Importance_enum.main.ToString();
            row.percent_of_importance = 75 + 12;
            Importance_table.AddImportance_tableRow( row );
            Importance_table.AcceptChanges();

        }

        private void create_default_phase()
        {
            Phase_tableRow row;
            row = (Phase_tableRow) Phase_table.NewRow();
            row.phase_id = (Int32)Phase_direction_enum.invariant;
            row.name_of_phase = Phase_direction_enum.invariant.ToString();
            row.importance_id_for_phase = (Int32)Importance_enum.main;
            Phase_table.AddPhase_tableRow(row);

            row = (Phase_tableRow)Phase_table.NewRow();
            row.phase_id = (Int32)Phase_direction_enum.before;
            row.name_of_phase = Phase_direction_enum.before.ToString();
            row.importance_id_for_phase = (Int32)Importance_enum.main;
            Phase_table.AddPhase_tableRow( row );

            row = (Phase_tableRow)Phase_table.NewRow();
            row.phase_id = (Int32)Phase_direction_enum.action;
            row.name_of_phase = Phase_direction_enum.action.ToString();
            row.importance_id_for_phase = (Int32)Importance_enum.main;
            Phase_table.AddPhase_tableRow( row );

            row = (Phase_tableRow)Phase_table.NewRow();
            row.phase_id = (Int32)Phase_direction_enum.after;
            row.name_of_phase = Phase_direction_enum.after.ToString();
            row.importance_id_for_phase = (Int32)Importance_enum.main;
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
                row.name_of_level = level.abstraction_level.ToString();
                row.importance_id_for_level = (Int32) level.importance ;
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
