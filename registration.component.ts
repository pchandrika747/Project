import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Registration } from 'src/Models/Registration';
import { RegisterationService } from '../registeration.service';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {
  router: any;
    
form:Registration
  constructor(private _service: RegisterationService,private route:Router, private active:ActivatedRoute) { }
  ngOnInit(): void {
    this.resetForm();
    }
    resetForm(form?:NgForm){
      if(form!=null)
        form.resetForm();
      this._service.formData={
        id:0,
        title:"",
    firstname:"",
    lastname:"",
    email:"",
    password:"",
    confirmpassword : "",
    dateofbirth:new Date(),
    phonenumber:0
      }
      }
      onSubmit(form:NgForm){
        this.adduser(form);
      }
      adduser(form:NgForm){
        this._service.postuser(form.value).subscribe(res=>{
          alert("Inserted successfully")
          this.resetForm(form)
        })
      }
}


