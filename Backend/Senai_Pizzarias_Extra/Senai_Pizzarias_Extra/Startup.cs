﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;

namespace Senai_Pizzarias_Extra {
    public class Startup {

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices (IServiceCollection services) {

            services.AddMvc ()
                .AddJsonOptions (options => {
                    options.SerializerSettings.NullValueHandling =
                        Newtonsoft.Json.NullValueHandling.Ignore;
                    options.SerializerSettings.ReferenceLoopHandling =
                        Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                })
                .SetCompatibilityVersion (Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1);

            services.AddAuthentication (options => {
                options.DefaultAuthenticateScheme = "JwtBearer";
                options.DefaultChallengeScheme = "JwtBearer";
            }).AddJwtBearer ("JwtBearer", options => {
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters {
                ValidateIssuer = true,

                ValidateAudience = true,

                ValidateLifetime = true,

                IssuerSigningKey = new SymmetricSecurityKey (System.Text.Encoding.UTF8.GetBytes ("Senai_Pizzarias_Extra-chave-autenticacao")),

                ClockSkew = TimeSpan.FromMinutes (30),

                ValidIssuer = "Senai_Pizzarias_Extra.WebApi",

                ValidAudience = "Senai_Pizzarias_Extra.WebApi"
                };
            });

            // Swagger section
            services.AddSwaggerGen (c => {
                c.SwaggerDoc ("v1", new Info { Title = "My API", Version = "v1" });
            });

            //configurando cors
            services.AddCors (options => {
                options.AddPolicy ("CorsPolicy",
                    builder => builder.AllowAnyOrigin ()
                    .AllowAnyMethod ()
                    .AllowAnyHeader ()
                    .AllowCredentials ());
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }

            app.UseSwagger ();

            app.UseSwaggerUI (c => {
                c.SwaggerEndpoint ("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication ();
            app.UseCors ("CorsPolicy");
            app.UseMvc ();
            app.UseStaticFiles ();
        }
    }
}