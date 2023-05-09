using SQLite;

namespace BookThing.Data;
public class BookDbController
{
    private readonly string _dbPath;

    private SQLiteAsyncConnection _connection;

    public BookDbController (string dbPath) => _dbPath = dbPath;

    public async Task InitializeAsync()
    {
        if (_connection != null)
            return;    
        _connection = new(_dbPath);
        await _connection.CreateTableAsync<BookData>();
    }

    public async Task<List<BookData>> GetAll()
    {
        await InitializeAsync();
        return await _connection.Table<BookData>().ToListAsync();
    }
    public async Task<BookData> Create (BookData data)
    {
        await _connection.InsertAsync(data);
        return data;
    }

    public async Task Edit (BookData data) => await _connection.UpdateAsync(data);
    public async Task Delete (BookData data) => await _connection.DeleteAsync(data);
}
