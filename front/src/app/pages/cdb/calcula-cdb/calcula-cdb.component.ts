import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CdbRequestsService } from 'src/app/http-requests/cdb-requests.service';

@Component({
  selector: 'app-calcula-cdb',
  templateUrl: './calcula-cdb.component.html',
  styleUrls: ['./calcula-cdb.component.css']
})
export class CalculaCdbComponent {

  cdbForm: FormGroup;
  result: any;

  constructor(private fb: FormBuilder,
    private request: CdbRequestsService) {
    this.cdbForm = this.fb.group(
      {
        ValorInicial: [0,  Validators.required],
        Meses: [0,  Validators.required],
      });
  }
  send() {
    console.log(this.cdbForm.value);
    this.request.calculaCdb(this.cdbForm.value).subscribe(
      ok => { 
        this.result = ok.data;
        this.cdbForm.reset();
      },
      error => alert(error.error.message)
    )
  }
}
