﻿/*
 * Copyright © 2013-2018, Amy Nagle.
 * All rights reserved.
 * 
 * This file is part of ZoraGen WPF.
 *
 * ZoraGen WPF is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * ZoraGen WPF is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with ZoraGen WPF.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zyrenth.ZoraGen.Wpf
{
	public class GitHubRelease
	{
		public string Name { get; set; }
		public string TagName { get; set; }
		public string Body { get; set; }
		public bool IsDraft { get; set; }
		public bool IsPreRelease { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? PublishedAt { get; set; }
		public string HtmlUrl { get; set; }
	}
}
