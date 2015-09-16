using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.DirectoryServices;

namespace Texfina.ERP
{
   public class ActiveDirectoryValidator
   {
      private string _path = "";
      private string _filterAttribute = "";

      public ActiveDirectoryValidator(string path)
      {
         _path = path;
      }

      public bool IsAuthenticated(string domainName, string userName, string password)
      {

         string domainAndUsername = domainName + "\\" + userName;
         DirectoryEntry entry = new DirectoryEntry(_path, domainAndUsername, password);

         object obj = entry.NativeObject;
         DirectorySearcher search = new DirectorySearcher(entry);
         search.Filter = "(SAMAccountName=" + userName + ")";
         search.PropertiesToLoad.Add("cn");
         SearchResult result = search.FindOne();
         if (result == null)
            return false;

         _path = result.Path;
         _filterAttribute = result.Properties["cn"][0].ToString();

         return true;

      }
   }
}