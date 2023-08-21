import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactiveforms',
  templateUrl: './reactiveforms.component.html',
  styleUrls: ['./reactiveforms.component.css'],
})
export class ReactiveformsComponent implements OnInit {
  ngOnInit(): void {}

  contactForm = new FormGroup({
    firstname: new FormControl('', [
      Validators.required,
      Validators.minLength(5),
      Validators.pattern('^[a-z A-Z]+$'),
    ]),
    lastname: new FormControl('', [
      Validators.required,
      Validators.minLength(5),
      Validators.pattern('^[a-z A-Z]+$'),
    ]),
    email: new FormControl('',[Validators.email]),
    gender: new FormControl(''),
    isMarried: new FormControl(''),
    country: new FormControl(''),
  });

  get firstname() {
    return this.contactForm.get('firstname')!;
  }

  get lastname() {
    return this.contactForm.get('lastname')!;
  }

  get email() {
    return this.contactForm.get('email')!;
  }

  get gender() {
    return this.contactForm.get('gender');
  }

  get isMarried() {
    return this.contactForm.get('isMarried');
  }

  get country() {
    return this.contactForm.get('country');
  }

  onSubmit() {
    console.log(this.contactForm.value);
  }
}
