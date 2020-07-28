﻿using Microsoft.EntityFrameworkCore;
using Senparc.Ncf.Core.Models;
using Senparc.Ncf.XncfBase;
using Senparc.Ncf.XncfBase.Database;
using Senparc.Xncf.WeixinManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Xncf.WeixinManager
{
    public class WeixinSenparcEntities : XncfDatabaseDbContext
    {
        public DbSet<MpAccount> MpAccounts { get; set; }
        public DbSet<WeixinUser> WeixinUsers { get; set; }
        public DbSet<UserTag> UserTags { get; set; }
        public DbSet<UserTag_WeixinUser> UserTags_WeixinUsers { get; set; }

        public WeixinSenparcEntities(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public override IXncfDatabase XncfDatabaseRegister => new Register();
    }
}