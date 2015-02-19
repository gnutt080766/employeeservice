public class DbConnect
{
 private ILogger _logger;
 private DbConnect _dbConnect;
 private DbConnect(ILogger logger)
 {
  if(logger != null)
  {
   _logger = logger;
  }
  else
  {
   throw new Exception("error: logger cannot be null");
  }
 }

 public static DbConnect Init()
 {
  if(_dbConnect == null)
  {
   _dbConnect = new DbConnect(logger);
  }
  return _dbConnect;
 }
}
