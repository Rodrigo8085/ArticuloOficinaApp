import { HttpClient } from '@angular/common/http';
import { Component, OnInit, TemplateRef, ViewChild, inject } from '@angular/core';
import { LoginService } from './services/login.service';
import { NgbModal, NgbOffcanvas } from '@ng-bootstrap/ng-bootstrap';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { IArticulo } from './interfaces/IArticulo';
import { ArticulosService } from './services/interaction/articulos.service';
import { Subscription } from 'rxjs';
import { ComprarService } from './services/comprar.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  sessionData: any;
  isLogged = false;
  mensaggeLogin = '';
  MensajeCompra = '';
  loginForm!: FormGroup;
  articulosShop: IArticulo[] = [];
  articulosInteractionService: Subscription;
  private offcanvasService = inject(NgbOffcanvas);


  @ViewChild('modalLogin', { static: false }) modalLogin: TemplateRef<any> | undefined;
  @ViewChild('shop', { static: false }) shop: TemplateRef<any> | undefined;

  constructor(
    private ls: LoginService,
    private modalService: NgbModal,
    private fb: FormBuilder,
    private as: ArticulosService,
    private cs: ComprarService
  ) { 
    this.articulosInteractionService = this.as.articuloEmmiter$.subscribe((event: IArticulo) => {
      this.articulosShop.push(event);
    });

  }

  ngOnInit() {
    this.validateLogin();
  }

  validateLogin() {
    this.sessionData = sessionStorage.getItem('login');
    if (this.sessionData.hasOwnProperty('email')) {
      this.isLogged = true;
    }
  }

  openModal() {
    let controls = {
      email: this.fb.control(''),
      password: this.fb.control('')
    };
    this.loginForm = this.fb.group(controls);
    
    this.modalService.open(
      this.modalLogin,
      {
        size: 'lg',
        backdrop: 'static',
        keyboard: false
      }
    );
  }

  logIn() {
    this.ls.obtener(this.loginForm.value).subscribe({
      next: (response: any) => {
        sessionStorage.setItem('login', response);
        this.validateLogin();
      },
      error: e => {
        this.mensaggeLogin = 'Verifica usuario o contraseña'
      }
    });
  }

  openShop(){
      this.offcanvasService.open(this.shop, { ariaLabelledBy: 'offcanvas-basic-title' });
  }

  asFormControl(toReturn: any) {
    return toReturn as FormControl;
  }

  comprar() {
    this.cs.shop(this.articulosShop).subscribe({
      next: (response: any) => {
        this.MensajeCompra = 'Compra Realizada'

      },
      error: e => {
        this.MensajeCompra = 'Error en compra'

      }
    });
  }

}
