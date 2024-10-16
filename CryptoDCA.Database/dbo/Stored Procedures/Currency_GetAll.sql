CREATE PROCEDURE [dbo].[Currency_GetAll]
	@onlyCrypto AS BIT = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DECLARE @SQL AS NVARCHAR(MAX) = N'';
    DECLARE @cryptoTypeId AS INT = (SELECT GOT_CURRENCY_TYPE.GOT_CURRENCY_TYPE_ID
                                    FROM GOT_CURRENCY_TYPE
                                    WHERE GOT_CURRENCY_TYPE.GOT_CURRENCY_TYPE_PROGID = 'CRYPTO');

 
	SET @SQL += N'
		SELECT *
		FROM dbo.[View_Currency]
        WHERE GOT_CURRENCY_ISACTIVE = 1
    ';

    IF @onlyCrypto = 1 
        SET @SQL += '
            AND [dbo].[View_Currency].[GOT_CURRENCY_TYPE_ID] = @cryptoTypeId
        ';
 

    exec sp_executesql @SQL, N'@onlyCrypto AS BIT
                              ,@cryptoTypeId AS INT'
							  ,@onlyCrypto
                              ,@cryptoTypeId
							  
END