app.service('LoginService', function($http) {
		
		return{
			gettoken:function(Username,Password,callback){
				
				//var string="{\"email\": \""+Username+"\",\"password\": \""+Password+"\"}"
			    //var data=JSON.parse(string);
			    var data = {}
			    data.Username = Username;
			    data.Password = Password;
			    var para = JSON.stringify(data);

				var config = {
						headers : {
							'Content-Type': 'application/json'
						}
					}
				
				return $http.post("http://localhost:50361/EmployeeService.asmx/Login",para,config).then(function successCallback(response) {
							return response;
				});
			}
		}
	}
);

app.service('ListAllUser', function($http) {
		
		return{
			Details:function(){
	
				var config = {
						headers : {
							'Content-Type': 'application/json'
						}
					}
				
				return $http.post('http://localhost:50361/EmployeeService.asmx/GetAllEmployee').then(function (data, status, header, config) {
					return data.data;
				});
			}
		}
	}
);	 
  
		 