import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CalculaCdbComponent } from './cdb/calcula-cdb/calcula-cdb.component';
import { CdbComponent } from './cdb/cdb.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpRequestsModule } from '../http-requests/http-requests.module';



@NgModule({
  declarations: [
    CalculaCdbComponent,
    CdbComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    HttpRequestsModule,
  ],
  exports: [ CdbComponent ]
})
export class PagesModule { }
