﻿namespace NZWalks.API.Models.Domain
{
    public class WalkDifficulty
    {

        public Guid Id { get; set; }
        public string Code { get; set; }

        //Navigation Property
        public Walk Walk { get; set; }
    }
}
