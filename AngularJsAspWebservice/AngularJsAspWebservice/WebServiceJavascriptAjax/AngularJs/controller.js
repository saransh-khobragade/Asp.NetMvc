app.controller('myCtrl', function($scope,$location) {
		$location.path('/Login')
	});

app.controller('LoginCtrl', function($scope,$location,$http,LoginService) {
    
    var response;

        $scope.Username = "saransh";
        $scope.Password = "12345";

		$scope.loginfunc=function(){
			
			//token=Services.AuthLogin($scope.Username,$scope.Password);
			response=LoginService.gettoken($scope.Username,$scope.Password);
			response.then(function(response) {
			    
				if(response.data.d=='ABCDEF')
					{	$location.path('/Details');	}
				else
					{	alert('Try again');			}
				});
			
			
		}
		
		
		$scope.Regfunc=function(){
			$location.path('/Register');
		}
	});

app.controller('DetailsCtrl', function($scope,ListAllUser) {
    
		ListAllUser.Details().then(function(response){
		    $scope.details = response;
		  
		});
		
	});
app.controller('RegCtrl', function($scope,ListAllUser) {
			
		$scope.submit=function(){
			alert('work is in progress')
		}
		
	});