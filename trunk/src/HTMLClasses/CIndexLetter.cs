/* CIndexLetter.cs
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
 * $Id: print.c 26850 2008-11-26 07:34:57Z jake $
 *
 * History:  
 * 10Dec08 AlexC          Migrated from GEDmill 1.10
 *
 */

using System;
using System.Collections;

namespace GEDmill.HTMLClasses
{
    // Data structure holding all the entries in the index under the given letter.
    // Title is usually the same as initial, except for no-surname case.
    public class CIndexLetter
    {
        public ArrayList m_alItems;
        public string m_sInitial;
        public string m_sTitle;

        // Noddy constructor
        public CIndexLetter( string initial, string title, ArrayList letterList )
        {
            m_sInitial = initial;
            m_sTitle = title;
            m_alItems = letterList;
        }
    }
}
