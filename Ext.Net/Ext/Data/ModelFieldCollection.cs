/********
 * This file is part of Ext.NET.
 *     
 * Ext.NET is free software: you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as 
 * published by the Free Software Foundation, either version 3 of the 
 * License, or (at your option) any later version.
 * 
 * Ext.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU AFFERO GENERAL PUBLIC LICENSE for more details.
 * 
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with Ext.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * @version   : 2.1.1 - Ext.NET Community License (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.ComponentModel;
using System.Globalization;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ModelFieldCollection : BaseItemCollection<ModelField> 
    {
		/// <summary>
		/// 
		/// </summary>
        public virtual void Add(params string[] names)
        {
            string[] parts;
            string name;

            foreach (string s in names)
            {
                name = s.Trim();

                if (name.Contains(":"))
                {
                    parts = name.Split(':');

                    try
                    {
                        this.Add(new ModelField(parts[0], (ModelFieldType)Enum.Parse(typeof(ModelFieldType), parts[1].ToTitleCase(CultureInfo.InvariantCulture))));
                        continue;
                    }
                    catch (ArgumentException) 
                    {
                        throw new ArgumentException("The RecordFieldType of \"" + parts[1] + "\" was not found");
                    }
                }
                
                this.Add(new ModelField(name));
            }
        }

		/// <summary>
		/// 
		/// </summary>
        public virtual void Add(string name)
        {
            if (name.Contains(","))
            {
                this.Add(name.Split(','));
            }
            else
            {
                this.Add(new string[]{name});
            }
        }

		/// <summary>
		/// 
		/// </summary>
        public virtual void Add(string name, ModelFieldType type)
        {
            this.Add(new ModelField(name, type));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="dateFormat"></param>
        public virtual void Add(string name, ModelFieldType type, string dateFormat)
        {
            this.Add(new ModelField(name, type, dateFormat));
        }

        /// <summary>
        ///  Get RecordField by name
        /// </summary>
        /// <param name="name">Field's name</param>
        /// <returns>RecordField</returns>
        public virtual ModelField Get(string name)
        {
            foreach (ModelField field in this)
            {
                if (field.Name == name)
                {
                    return field;
                }
            }

            return null;
        }
    }
}
