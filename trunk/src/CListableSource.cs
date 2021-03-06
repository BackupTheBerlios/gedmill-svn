/* CListableSource.cs
 * 
 * Copyright 2009 Alexander Curtis <alex@logicmill.com>
 * This file is part of GEDmill - A family history website creator
 * 
 * GEDmill is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * GEDmill is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with GEDmill.  If not, see <http://www.gnu.org/licenses/>.
 *
 * History:  
 * 10Dec08 AlexC          Migrated from GEDmill 1.10
 *
 */

using System;
using System.Windows.Forms;
using GEDmill.LLClasses;

namespace GEDmill
{
    // Represents a source record in the list of sources, and provides sorting.
    public class CListableSource : ListViewItem.ListViewSubItem
    {
        // The record in question
        private CSourceRecord m_sr;

        // Constructor
        public CListableSource( CSourceRecord sr )
        {
            m_sr = sr;
            base.Text = ToString();
        }

        // Used by the list box to display the name of the source
        public override string ToString()
        {
            return m_sr.ToString();         
        }

        // Used when sorting the list box
        public int CompareTo(CListableSource other) 
        {
            return m_sr.DescriptiveTitle.CompareTo(other.m_sr.DescriptiveTitle);
        }

    }

}
