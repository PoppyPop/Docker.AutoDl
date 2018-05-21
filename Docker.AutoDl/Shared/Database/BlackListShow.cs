using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Docker.AutoDl.Shared.Database
{
    public class BlackListShow
    {
        public Guid? Id { get; set; }

        public uint TraktShowId { get; set; }

        public string SerieName { get; set; }

        public bool Entire { get; set; }

        public int? Season { get; set; }
    }
}
