﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.FarmSystem.Seeds
{
    class CottonSeed : GrowableSeed
    {
        [Constructable]
        public CottonSeed()
            : base(CropType.Cotton)
        {
        }

        public CottonSeed(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
        }
    }
}
