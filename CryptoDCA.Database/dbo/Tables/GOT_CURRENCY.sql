﻿CREATE TABLE [dbo].[GOT_CURRENCY] (
    [GOT_CURRENCY_ID]       INT            IDENTITY (1, 1) NOT NULL,
    [GOT_CURRENCY_NAME]     NVARCHAR (MAX) NOT NULL,
    [GOT_CURRENCY_SYMBOL]   NVARCHAR (MAX) NOT NULL,
    [GOT_CURRENCY_ISACTIVE] BIT            NOT NULL,
    [GOT_CURRENCY_TYPE_ID]  INT            NOT NULL,
    CONSTRAINT [PK_GOT_CURRENCY] PRIMARY KEY CLUSTERED ([GOT_CURRENCY_ID] ASC),
    CONSTRAINT [FK_GOT_CURRENCY_GOT_CURRENCY_TYPE_GOT_CURRENCY_TYPE_ID] FOREIGN KEY ([GOT_CURRENCY_TYPE_ID]) REFERENCES [dbo].[GOT_CURRENCY_TYPE] ([GOT_CURRENCY_TYPE_ID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_GOT_CURRENCY_GOT_CURRENCY_TYPE_ID]
    ON [dbo].[GOT_CURRENCY]([GOT_CURRENCY_TYPE_ID] ASC);
