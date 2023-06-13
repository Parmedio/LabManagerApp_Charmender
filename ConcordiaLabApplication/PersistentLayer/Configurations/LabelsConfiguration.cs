﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PersistentLayer.Models;

namespace PersistentLayer.Configurations
{
    public class LabelsConfiguration : IEntityTypeConfiguration<Label>
    {
        public void Configure(EntityTypeBuilder<Label> entity)
        {
            entity.HasData(
                    new Label(TrelloId: "647609751afdaf2b05536cd9", Title: "Medium"),
                    new Label(TrelloId: "647609751afdaf2b05536cd7", Title: "Low"),
                    new Label(TrelloId: "647609751afdaf2b05536cdf", Title: "High"),
                    new Label(TrelloId: "647608041afdaf2b0545a16c", Title: "Medium"),
                    new Label(TrelloId: "647608041afdaf2b0545a16b", Title: "High"),
                    new Label(TrelloId: "647608041afdaf2b0545a160", Title: "Low")

                );
        }
    }
}