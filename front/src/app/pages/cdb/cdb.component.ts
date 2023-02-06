import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-cdb',
  templateUrl: './cdb.component.html',
  styleUrls: ['./cdb.component.css']
})
export class CdbComponent  implements OnInit  {
  

  constructor(private fb: FormBuilder,){}

  ngOnInit(): void {}
}
