﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VueChatApp.Features.AccessControl.Entities;
using VueChatApp.Features.Chat.Entities;
using VueChatApp.Features.DocumentsManager.Documents.Entities;
using VueChatApp.Features.QrCode.Entities;

namespace VueChatApp.Data
{
    public class ChatDbContext : IdentityDbContext<SystemUser, IdentityRole<long>, long>
    {
        public ChatDbContext(DbContextOptions<ChatDbContext> options) : base(options) => Database.EnsureCreated();
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<Document> Documents { get; set; }
        
        public DbSet<QrCode> QrCodes { get; set; }
    }
}
