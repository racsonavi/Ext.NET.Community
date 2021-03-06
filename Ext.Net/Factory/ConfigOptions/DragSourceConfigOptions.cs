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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DragSource
    {
        /// <summary>
        /// 
        /// </summary>
		[Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                
                list.Add("group", new ConfigOption("group", new SerializationOptions("ddGroup"), "", this.Group ));
                list.Add("dragDataProxy", new ConfigOption("dragDataProxy", new SerializationOptions("dragData", JsonMode.Raw), "", this.DragDataProxy ));
                list.Add("animRepair", new ConfigOption("animRepair", null, true, this.AnimRepair ));
                list.Add("dropAllowed", new ConfigOption("dropAllowed", null, "x-dd-drop-ok", this.DropAllowed ));
                list.Add("dropNotAllowed", new ConfigOption("dropNotAllowed", null, "x-dd-drop-nodrop", this.DropNotAllowed ));
                list.Add("repairHighlightColor", new ConfigOption("repairHighlightColor", null, "c3daf9", this.RepairHighlightColor ));
                list.Add("afterDragDrop", new ConfigOption("afterDragDrop", new SerializationOptions(JsonMode.Raw), null, this.AfterDragDrop ));
                list.Add("afterDragEnter", new ConfigOption("afterDragEnter", new SerializationOptions(JsonMode.Raw), null, this.AfterDragEnter ));
                list.Add("afterDragOut", new ConfigOption("afterDragOut", new SerializationOptions(JsonMode.Raw), null, this.AfterDragOut ));
                list.Add("afterDragOver", new ConfigOption("afterDragOver", new SerializationOptions(JsonMode.Raw), null, this.AfterDragOver ));
                list.Add("afterInvalidDrop", new ConfigOption("afterInvalidDrop", new SerializationOptions(JsonMode.Raw), null, this.AfterInvalidDrop ));
                list.Add("afterValidDrop", new ConfigOption("afterValidDrop", new SerializationOptions(JsonMode.Raw), null, this.AfterValidDrop ));
                list.Add("beforeDragDrop", new ConfigOption("beforeDragDrop", new SerializationOptions(JsonMode.Raw), null, this.BeforeDragDrop ));
                list.Add("beforeDragEnter", new ConfigOption("beforeDragEnter", new SerializationOptions(JsonMode.Raw), null, this.BeforeDragEnter ));
                list.Add("beforeDragOut", new ConfigOption("beforeDragOut", new SerializationOptions(JsonMode.Raw), null, this.BeforeDragOut ));
                list.Add("beforeDragOver", new ConfigOption("beforeDragOver", new SerializationOptions(JsonMode.Raw), null, this.BeforeDragOver ));
                list.Add("beforeInvalidDrop", new ConfigOption("beforeInvalidDrop", new SerializationOptions(JsonMode.Raw), null, this.BeforeInvalidDrop ));
                list.Add("onBeforeDrag", new ConfigOption("onBeforeDrag", new SerializationOptions(JsonMode.Raw), null, this.OnBeforeDrag ));
                list.Add("onStartDrag", new ConfigOption("onStartDrag", new SerializationOptions(JsonMode.Raw), null, this.OnStartDrag ));
                list.Add("getDragData", new ConfigOption("getDragData", new SerializationOptions(JsonMode.Raw), null, this.GetDragData ));

                return list;
            }
        }
    }
}