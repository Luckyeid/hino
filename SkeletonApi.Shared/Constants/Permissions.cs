﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonApi.Shared.Constants
{
    public static class Permissions
    {
        public static List<string> GeneratePermissionsForModule(string module)
        {
            return new List<string>()
            {
                $"Permissions.{module}.Create",
                $"Permissions.{module}.View",
                $"Permissions.{module}.Edit",
                $"Permissions.{module}.Delete",
            };
        }
        public static List<string> GeneratePermissionsForPm(string Pm)
        {
            return new List<string>()
            {
                $"Permissions.Users.{Pm}",
                $"Permissions.Users.{Pm}",
                $"Permissions.Users.{Pm}",
                $"Permissions.Users. {Pm}",
            };
        }

        public static class Dashboards
        {
            public const string View = "Permissions.Dashboards.View";
            public const string Create = "Permissions.Dashboards.Create";
            public const string Edit = "Permissions.Dashboards.Edit";
            public const string Delete = "Permissions.Dashboards.Delete";
        }

        public static class Users
        {
            public const string View = "Permissions.Users.View";
            public const string Create = "Permissions.Users.Create";
            public const string Edit = "Permissions.Users.Edit";
            public const string Delete = "Permissions.Users.Delete";
        }

    }

    public class CustomClaimTypes
    {
        public const string Permission = "Permission";
    }
}
