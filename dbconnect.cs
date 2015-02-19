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
   _logger = new Logger();
  }
 }

 public static DbConnect Init(ILogger logger = null)
 {
  if(_dbConnect == null)
  {
   _dbConnect = new DbConnect(logger);
  }
  return _dbConnect;
 }
 
 public bool IsInitialized
 {
	 get
	 {
	 if(_dbConnect == null)
		 return false;
	 else
		 return true;
	}
 }
}
