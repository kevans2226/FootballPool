import { HttpClient} from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  loginForm = new FormGroup({ 
    userName: new FormControl('', Validators.required), 
    password: new FormControl('', Validators.required)
  })

  constructor(private _httpClient: HttpClient) { }

  ngOnInit(): void {
  }

  login() : void { 

    var loginRecord = {
      username: this.loginForm.get("userName")?.value, 
      password: this.loginForm.get("password")?.value
    };

    this._httpClient.post("/api/Authenticate/login", loginRecord).subscribe(result => { 
      console.log(result);
    })
  }


}
