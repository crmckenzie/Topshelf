﻿// Copyright 2007-2011 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Topshelf.Options
{
	using System;
	using HostConfigurators;


	public class ServiceAccountOption :
		Option
	{
		readonly string _password;
		readonly string _username;

		public ServiceAccountOption(string username, string password)
		{
			_username = username;
			_password = password;
		}

		public void ApplyTo(HostConfigurator configurator)
		{
			configurator.RunAs(_username, _password);
		}
	}

	public class SudoOption :
		Option
	{
		public void ApplyTo(HostConfigurator configurator)
		{
			configurator.AddConfigurator(new SudoConfigurator());
		}
	}
}