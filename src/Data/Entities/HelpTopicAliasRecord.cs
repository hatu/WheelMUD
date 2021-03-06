﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="HelpTopicAliasRecord.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by EntityRecord.cst on 7/7/2012 4:24:09 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Entities
{
	using System;

    using ServiceStack.DataAnnotations;
	
    ///<summary>
    /// Represents a single HelpTopicAlias row in the HelpTopicAlias table.
    ///</summary>
    [Alias("HelpTopicAliases")]
	public partial class HelpTopicAliasRecord 
	{
        [AutoIncrement]
        public virtual long ID { get; set; }
        public virtual string HelpTopicAlias { get; set; }
        public virtual long HelpTopicID { get; set; }
	}
}

