﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="RoleRecord.cs" company="WheelMUD Development Team">
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
    /// Represents a single Role row in the Role table.
    ///</summary>
    [Alias("Roles")]
	public partial class RoleRecord 
	{
        [AutoIncrement]
        public virtual long ID { get; set; }
        public virtual string Name { get; set; }
        public virtual int SecurityRoleMask { get; set; }
	}
}

