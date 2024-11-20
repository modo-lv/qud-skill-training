﻿using System;
using XRL.World.Skills;

namespace SkillTraining.Utils {
  public static class Skills {
    /// <summary>
    /// Gets the display name (<c>"Long Blades"</c>) of a skill class (<c>"LongBlades"</c>).
    /// </summary>
    /// <remarks>
    /// Weirdly, <see cref="SkillFactory.SkillList"/> is also indexed by the display name,
    /// rather than skill class.
    /// </remarks>
    public static String SkillName(this String skillClass) =>
      SkillFactory.GetSkillOrPowerName(skillClass);
  }
}