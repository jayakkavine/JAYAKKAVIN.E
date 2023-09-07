import { Component } from '@angular/core';

@Component({
  selector: 'app-mortgage-calculator',
  templateUrl: './mortgage-calculator.component.html',
  styleUrls: ['./mortgage-calculator.component.css']
})
export class MortgageCalculatorComponent {
  purchasePrice!: number;
  downPayment!: number;
  repaymentTime!: number;
  interestRate!: number;
  amount: number = 0;

  get loanAmount(): number {
    
    this.amount = this.purchasePrice - this.downPayment;
    return this.amount;
  }

  get monthlyPayment(): number {
    const monthlyInterestRate = this.interestRate / 100 / 12;
    const numberOfPayments = this.repaymentTime * 12;
    return (
      (this.loanAmount * monthlyInterestRate) /
      (1 - Math.pow(1 + monthlyInterestRate, -numberOfPayments))
    );
  }
}
