import { HttpClient } from '@angular/common/http';
import { ComponentFixture, TestBed } from '@angular/core/testing';
import { CdbRequestsService } from 'src/app/http-requests/cdb-requests.service';
import { CalculaCdbComponent } from './calcula-cdb.component';

describe('CalculaCdbComponent', () => {
  let httpClientSpy: jasmine.SpyObj<HttpClient>;
  let component: CalculaCdbComponent;
  let fixture: ComponentFixture<CalculaCdbComponent>;
  let cdbRequestsService: CdbRequestsService;
  let results = {
    success: true,
    message: '',
    data: {
      valorFinal: 1019.5344783999999,
      valorInicial: 1000,
      cdi: 0.009000000000000001,
      taxaBanco: 1.08,
      valorLiquido: 1015.13922076,
      ganho: 19.534478399999898,
      meses: 2
    }
  };

  beforeEach(async () => {

    let httpClientSpyObj = jasmine.createSpyObj('HttpClient', ['post']);

    await TestBed.configureTestingModule({
      declarations: [ CalculaCdbComponent ],
      providers : [
        CdbRequestsService,
        {
          provide: HttpClient,
          useValue: httpClientSpyObj
        }
      ]
    })
    .compileComponents();

    cdbRequestsService = TestBed.inject(CdbRequestsService);
    httpClientSpy = TestBed.inject(HttpClient) as jasmine.SpyObj<HttpClient>;

    fixture = TestBed.createComponent(CalculaCdbComponent);
    httpClientSpy = TestBed.inject(HttpClient) as jasmine.SpyObj<HttpClient>;
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('Botão ', () => {
    component.cdbForm.reset()
    fixture.detectChanges();
    const submitEl = fixture.debugElement.nativeElement.querySelector('#btnCalcular');
    expect(submitEl.nativeElement.querySelector('button').disabled).toBeTruthy();
   });
});
