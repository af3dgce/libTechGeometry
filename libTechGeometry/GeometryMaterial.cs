﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libTechGeometry {
	public class GeometryMaterial : IImportable {
		public string Name;

		public GeometryMaterial(string Name = null) {
			this.Name = Name;
		}
	}
}
