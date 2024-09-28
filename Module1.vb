Module Module1

    Private server = "LAPTOP-CBBIE80H"
    Private dataBase = "dev_prova"
    Private user = "sa"
    Private password = "dev01"

    Public ReadOnly strCon = $"Data Source={server}; Integrated Security=true; Initial Catalog={dataBase}; User ID={user}; Password={password};"

End Module
